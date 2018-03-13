using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cdn_api;
using api = cdn_api.cdn_api;

namespace DataModels.Logika
{
    public class CDNApi
    {
        private int _sesja;

        public void LogOut(int sesja)
        {
            XLLogoutInfo_20152 LogOFF = new XLLogoutInfo_20152();

            var wynik = cdn_api.cdn_api.XLLogout(sesja);
        }
        public void LogOut()
        {
            XLLogoutInfo_20152 LogOFF = new XLLogoutInfo_20152();

            var wynik = cdn_api.cdn_api.XLLogout(_sesja);
        }

        public bool LogIn(ref int sesja)
        {
            sesja = 0;
            int wynik;
            XLLoginInfo_20152 LogINFO = new XLLoginInfo_20152
            {
                Wersja = 20152,
                UtworzWlasnaSesje = 1,
                Winieta = -1,
                TrybWsadowy = 1,
                ProgramID = "DrukPIET",
                OpeIdent = ConfigurationManager.AppSettings["CDNLogin"],
                OpeHaslo = ConfigurationManager.AppSettings["CDNPass"],
                Baza = ConfigurationManager.AppSettings["CDNBaza"],
                SerwerKlucza = ConfigurationManager.AppSettings["SerwerKlucza"]
            };
            // brak formatki powitalnej
            // LogINFO.PlikLog = @"C:\log.txt";

            wynik = cdn_api.cdn_api.XLLogin(LogINFO, ref sesja);
            cdn_api.XLKomunikatInfo_20152 kom = new cdn_api.XLKomunikatInfo_20152
            {
                Funkcja = 5,
                Blad = wynik,
                Wersja = 20152
            };
            api.XLOpisBledu(kom);

            if (wynik == 0)
                return true;

            return false;
        }
            public bool LogIn()
        {
            _sesja = 0;
            int wynik;
            XLLoginInfo_20152 LogINFO = new XLLoginInfo_20152
            {
                Wersja = 20152,
                UtworzWlasnaSesje = 1,
                Winieta = -1,
                TrybWsadowy = 1,
                ProgramID = "DrukPIET",
                OpeIdent = ConfigurationManager.AppSettings["CDNLogin"],
                OpeHaslo = ConfigurationManager.AppSettings["CDNPass"],
                Baza = ConfigurationManager.AppSettings["CDNBaza"],
                SerwerKlucza = ConfigurationManager.AppSettings["SerwerKlucza"]
            };
            // brak formatki powitalnej
            // LogINFO.PlikLog = @"C:\log.txt";

            wynik = cdn_api.cdn_api.XLLogin(LogINFO, ref _sesja);
            cdn_api.XLKomunikatInfo_20152 kom = new cdn_api.XLKomunikatInfo_20152
            {
                Funkcja = 5,
                Blad = wynik,
                Wersja = 20152
            };
            api.XLOpisBledu(kom);

            if (wynik == 0)
                return true;

            return false;
        }

        public bool LogIn(string programName)
        {
            _sesja = 0;
            int wynik;
            XLLoginInfo_20152 LogINFO = new XLLoginInfo_20152
            {
                Wersja = 20152,
                UtworzWlasnaSesje = 1,
                Winieta = -1,
                TrybWsadowy = 1,
                ProgramID = programName,
                OpeIdent = ConfigurationManager.AppSettings["CDNLogin"],
                OpeHaslo = ConfigurationManager.AppSettings["CDNPass"],
                Baza = ConfigurationManager.AppSettings["CDNBaza"],
                SerwerKlucza = ConfigurationManager.AppSettings["SerwerKlucza"]
            };
            // brak formatki powitalnej
            // LogINFO.PlikLog = @"C:\log.txt";

            wynik = cdn_api.cdn_api.XLLogin(LogINFO, ref _sesja);
            cdn_api.XLKomunikatInfo_20152 kom = new cdn_api.XLKomunikatInfo_20152
            {
                Funkcja = 5,
                Blad = wynik,
                Wersja = 20152
            };
            api.XLOpisBledu(kom);

            if (wynik == 0)
                return true;

            return false;
        }

        public bool Drukuj(int zrodlo, int wydruk, int format, string filtr, string drukarka)
        {
            XLWydrukInfo_20152 wydrukInfo = new XLWydrukInfo_20152
            {
                Wersja = 20152,
                Zrodlo = zrodlo,
                Wydruk = wydruk,
                Format = format,
                NazwaDrukarki = drukarka,
                FiltrTPS = " " + filtr + " ",
                FiltrSQL = " " + filtr + " "
            };
            int wynik = 0;
            wynik = api.XLWykonajPodanyWydruk(wydrukInfo);

            return wynik == 0 ? true : false;
        }
        public bool Drukuj(int zrodlo, int wydruk, int format, string filtr)
        {
            XLWydrukInfo_20152 wydrukInfo = new XLWydrukInfo_20152
            {
                Wersja = 20152,
                Zrodlo = zrodlo,
                Wydruk = wydruk,
                Format = format,
                //NazwaDrukarki = drukarka,
                FiltrTPS = " " + filtr + " ",
                FiltrSQL = " " + filtr + " "
            };
            int wynik = 0;
            wynik = api.XLWykonajPodanyWydruk(wydrukInfo);

            return wynik == 0 ? true : false;
        }

        public bool DrukujDoPdf(int zrodlo, int wydruk, int format, string filtr, string filePath)
        {
            XLWydrukInfo_20152 wydrukInfo = new XLWydrukInfo_20152
            {
                Wersja = 20152,
                Zrodlo = zrodlo,
                Wydruk = wydruk,
                Format = format,
                DrukujDoPliku = 1,
                PlikDocelowy = filePath,
                FiltrTPS = " " + filtr + " ",
                FiltrSQL = " " + filtr + " "
            };
            int wynik = 0;
            wynik = api.XLWykonajPodanyWydruk(wydrukInfo);

            return wynik == 0 ? true : false;
        }
    }
}
