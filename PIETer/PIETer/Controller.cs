
using System.Configuration;
using System.Drawing.Printing;
using System.Linq;
using System.Threading;
using System.Windows.Media;
using DataModels.Logika;
using DataModels.Model;

namespace PIETer
{
    public class Controller
    {
        private IView _view;
        private bool isUserLoggedIn;
        private string userName;
        private ApplicationDbContext _context;
        private CDNApi _cdnApi;

        public Controller(IView view)
        {
            isUserLoggedIn = false;
            _context = new ApplicationDbContext();
            _cdnApi = new CDNApi();
            _view = view;
        }

        public void AnalyseBarcode(string barcode)
        {
            if (isUserLoggedIn)
            {
                //zrob cos jesli uzytkownik jest zalogowany
                if (barcode.Equals("FINISH"))
                {
                    LogOut();
                }
                else
                {
                    PrintPIET(barcode);
                }
                
            }
            else
            {
                //logowanie
                //sprawdzenie czy podany kod jest w liscie uzytkownikow
                LogIn(barcode);
            }
        }

        private void LogIn(string user)
        {
            var users = Tools.ParseOdbiorcy(ConfigurationManager.AppSettings[lConfigKey.Users]);

            if (users.Contains(user))
            {
                if (_cdnApi.LogIn("DrukPIET"))
                {
                    userName = user;
                    isUserLoggedIn = true;
                    _view.DisplayTopInfo("Zeskanuj kod WM", Colors.Black);
                    _view.DisplayBottomInfo("Zalogowano pomyślnie", Colors.Green);
                    _view.DisplayCurrentUser(userName);
                }
                else
                {
                    _view.DisplayBottomInfo("Problem z API, mozliwy brak licencji", Colors.Red);
                }
            }
            else
            {
                _view.DisplayBottomInfo("Niepoprawna nazwa użytkownika", Colors.Red);
                
            }
        }

        public bool LogOut()
        {
                if (isUserLoggedIn)
                {
                    userName = "";
                    _view.DisplayCurrentUser(userName);
                    isUserLoggedIn = false;
                    _cdnApi.LogOut();
                    _view.DisplayBottomInfo("Wylogowano", Colors.Green);
                    _view.DisplayTopInfo("Wprowadź użytkownika", Colors.Black);
                return true;
                }                   
            return false;
        }

        private void PrintPIET(string barcode)
        {
            if (barcode.Length == 0)
                return; // cos dziwnego sie dzieje... program uruchamia sie dwa razy bez wyraznego powodu
                        // to wychwytuje to ponowne uruchomienie
            
            
            if (!barcode.IsNumeric())
            {
                _view.DisplayBottomInfo("Kod musi zawierać same cyfry", Colors.Red);
                return;
            }

            if (barcode.Length < 19)
            {
                _view.DisplayBottomInfo("Kod musi składać się z 19 znaków", Colors.Red);
                return;
            }

            int GIDTyp = ExtractGidTyp(barcode);
            int GIDNumer = ExtractGidNumer(barcode);

            if (GIDTyp != 1601)
            {
                _view.DisplayBottomInfo("Zeskanowany dokument nie prowadzi do dokumentu WM", Colors.Red);
                return;
            }

            var dokumentWM = _context.MagNag.FirstOrDefault(d => d.MaN_GIDTyp == GIDTyp && d.MaN_GIDNumer == GIDNumer);

            if (dokumentWM == null || GIDNumer == 0)
            {
                _view.DisplayBottomInfo("Dokument nie istnieje", Colors.Red);
                return;
            }

            var ktoSkanowal = _context.GetAtr(GIDTyp, GIDNumer, _Atrybuty.PIETSkanowalUzytkownik);

            if (!string.IsNullOrWhiteSpace(ktoSkanowal))
            {
                _view.DisplayBottomInfo("Ten kod był już skanowany przez: " + ktoSkanowal, Colors.Red);
                return;
            }

            string nazwaDokumentu = _context.GetDokument(GIDTyp, GIDNumer);
            string filtr = "MaN_GIDTyp = " + GIDTyp.ToString() +" AND MaN_GIDNumer = " + GIDNumer.ToString();
            //string drukarka = ConfigurationManager.AppSettings[lConfigKey.Drukarka];

            if (!_cdnApi.Drukuj(1, 4, 1, filtr))
            {
                _view.DisplayBottomInfo("Wystąpił błąd przy drukowaniu", Colors.Red);
                return;
            }
            
            _view.DisplayBottomInfo("Wydruk PIET dla dokumentu: " + nazwaDokumentu, Colors.Green);
            _context.SetAtr(GIDTyp, GIDNumer, _Atrybuty.PIETSkanowalUzytkownik, userName);
        }

        private int ExtractGidTyp(string barcode)
        {
            string tempBarcode = barcode.Remove(0, 3);
            tempBarcode = tempBarcode.Remove(4, 12);

            int result = int.Parse(tempBarcode);
            return result;
        }

        private int ExtractGidNumer(string barcode)
        {
            string tempBarcode = barcode.Remove(0, 7);
            tempBarcode = tempBarcode.Remove(10, 2);
            var characters = tempBarcode.ToCharArray();

            int ZerosCountToRemove = 0;
            foreach (char character in characters)
            {
                if (!character.Equals('0'))
                    break;
                    ZerosCountToRemove++;
            }
            tempBarcode = tempBarcode.Remove(0, ZerosCountToRemove);
            int result;
            if (int.TryParse(tempBarcode, out result))
            {
                return result;
            }

           
            return 0;
        }
    }
}
