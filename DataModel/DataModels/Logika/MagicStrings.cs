using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Logika
{
    public static class ConfigKey
    {
        public const string attachmentFilePath = "attachmentFilePath";
        public const string odbiorcyZewnetrzni = "odbiorcyZewnetrzni";
        public const string odbiorcyLokalni = "odbiorcyLokalni";
        public const string odbiorcyDoWiadomosci = "odbiorcyDoWiadomosci";
        public const string odbiorcyErrors = "odbiorcyErrors";
        public const string CDNLogin = "CDNLogin";
        public const string CDNPass = "CDNPass";
        public const string CDNBaza = "CDNBaza";
        public const string SerwerKlucza = "SerwerKlucza";
        public const string CzasPetli = "CzasPetli";
        public const string Magazyny = "Magazyny";
        public const string KlasaTowaru = "KlasaTowaru";
        public const string excelFilePath = "excelFilePath";
        public const string excelFileDestination = "excelFileDestination";
        public const string excelLogFile = "excelLogFile";
        public const string pdfFilePath = "pdfFilePath";
        public const string emailNadawca = "emailNadawca";
        public const string emailLogin = "emailLogin";
        public const string emailPass = "emailPass";
        public const string emailSMTP = "emailSMTP";
    }

    public static class ErrorsCodes
    {
        public const int NoLicence = 0;
        public const int NoAttachemnt = 1;
        public const int PrintingFailed = 2;
        public const int MailSendFailed = 3;
    }

    public static class Knt
    {
        public const string Otto = "45008";
        public const string Ado = "27230";
        public const string Toppoint = "28194";
    }

    public static class WMFields
    {
        public const string AwF_OTTOSent = "AwF_OTTOSent";
        public const string AwF_CHNOSent = "AwF_CHNOSent";
        public const string AwF_FIXSent = "AwF_FIXSent";
        public const string AwF_EXPSent = "AwF_EXPSent";
    }

    public static class ZSFields
    {
        public const string AzF_FIX = "AzF_FIX";
        public const string AzF_OrderConfirmation = "AzF_OrderConfirmation";
        public const string AzF_NewOttoZlc = "AzF_NewOttoZlc";
    }

    public static class PWFields
    {
        public const string ApF_PWDoWygenerowania = "ApF_PWDoWygenerowania";
    }

    public static class Tables
    {
        public const string AUTO_PW_Flagi = "RILETA.AUTO_PW_Flagi";
        public const string AUTO_ZS_Flagi = "RILETA.AUTO_ZS_Flagi";
        public const string AUTO_WM_Flagi = "RILETA.AUTO_WM_Flagi";
    }

    public static class Attributes
    {
        public const int Komisja = 15;
        public const int Artykul = 12;
        public const int NrPartii = 13;
        public const int NazwaDoPlanowania = 209;
        public const int ZS_ilosc_got = 147;
        public const int ZS_ilosc_uszyta = 67;
        public const int ZS_Data_uzgod_klient = 69;
        public const int ZS_Data_dost_tkaniny = 100;
        public const int Data_przyjecia_towaru = 50;
        public const int Data_zapotrzebowania_materialowego = 65;
        public const int Wycofane_z_prod_powód_klient = 65;
        public const int ZS_Powrot_prod = 68;
        public const int ZS_bemarkung_admin = 70;
        public const int Uwagi_do_statusu_pl = 66;
        public const int ZS_IntercompanyOrder = 166;
        public const int ZS_pozycja_z_pliku = 102;
    }

  



}
