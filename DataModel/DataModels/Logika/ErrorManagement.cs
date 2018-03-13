using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels.Model;

namespace DataModels.Logika
{

    public class ErrorManager
    {
     
        private static List<Error> _caughtErrors = new List<Error>();
        private static Dictionary<int, Error> errDict = new Dictionary<int, Error>();

        static ErrorManager()
        {
            errDict.Add(ErrorsCodes.MailSendFailed, new Error
            {
                ErrorCode = ErrorsCodes.MailSendFailed,
                ErrorMessage = "Nie udało się wysłać wiadomości email, Dokument:",
                Process = "",
                Method = ""

            });
            errDict.Add(ErrorsCodes.NoAttachemnt, new Error
            {
                ErrorCode = ErrorsCodes.NoAttachemnt,
                ErrorMessage = "Brak zalacznika",
                Process = "",
                Method = ""

            });
            errDict.Add(ErrorsCodes.NoLicence, new Error
            {
                ErrorCode = ErrorsCodes.NoLicence,
                ErrorMessage = "Brak licencji dostepowej",
                Process = "",
                Method = ""

            });
            errDict.Add(ErrorsCodes.PrintingFailed, new Error
            {
                ErrorCode = ErrorsCodes.PrintingFailed,
                ErrorMessage = "Nie udalo sie wygenerowac zalacznika",
                Process = "",
                Method = ""

            });

        }

        public static void AddError(int errorId, string process, string method, string target)
        {
            _caughtErrors.Add(new Error
            {
                ErrorCode = errorId,
                ErrorMessage = errDict[errorId].ErrorMessage,
                Process = process,
                Method = method,
                Target = target
            });
        }

        public static void Add(Error _error)
        {
            _caughtErrors.Add(_error);
        }

        public static List<Error> CaughtErrors
        {
            get { return _caughtErrors; }
        }

        public static void AddErrorNoLicence()
        {
            Add(new Error
            {
                ErrorMessage = "Nie udało się uzyskać licencji.",
                ErrorCode = ErrorsCodes.NoLicence,
                Process = "AUTO_PotwierdzenieZamowienia",
                Method = "LogIn"

            });
        }

        public static void AddErrorMailSendFailed(string dokument)
        {
            Add(new Error
            {
                ErrorMessage = "Nie udało się wysłać wiadomości email, Dokument: " + dokument,
                ErrorCode = ErrorsCodes.MailSendFailed,
                Process = "AUTO_OttoMail",
                Method = "SendMails"

            });
        }

        public static void AddErrorNoAttachemnt()
        {
            
        }

        public static void AddErrorPrintingFailed(string dokument)
        {
            Add(new Error
            {
                ErrorMessage = "Nie udało się wygenerować wydruku. Dokument: " + dokument,
                ErrorCode = ErrorsCodes.NoAttachemnt,
                Process = "DrukujDoPdf",
                Method = "SendMails"

            });
        }

    }

    public class Error
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string Method { get; set; }
        public string Process { get; set; }
        public string Target { get; set; }
        
    }


}
