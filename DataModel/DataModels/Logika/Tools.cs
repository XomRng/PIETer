using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Logika
{
    public class Tools
    {
        public static string GetStatusZlc(int ZaN_Stan)
        {
            switch (ZaN_Stan)
            {
                case 3:
                    return "Potwierdzone";
                    //break;
                case 2:
                    return "Niepotwierdzone";
                    //break;
                case 21:
                    return "Zrealizowane";
                   // break;
                case 5:
                    return "W realizacji";
                    //break;
                case 35:
                    return "Anulowane";
                //break;
                default:
                    return "Inny";
            }
            return "";
        }

        public static DateTime TSToDate(int numDate)
        {
            DateTime firstDate = new DateTime(1800, 12, 28);
            firstDate = firstDate.AddDays(numDate);
            return firstDate;
        }

        public static int DateToTS(DateTime date)
        {
            int days;
            DateTime firstDate = new DateTime(1800, 12, 28);
            days = (int)(date - firstDate).TotalDays;
            return days;
        }

        public static void DeleteFileIfExists(string filePath)
        {
            FileInfo file = new FileInfo(filePath);

            if (file.Exists)
                file.Delete();
        }

        public static void DeleteFileIfExists(FileInfo file)
        {
            if(file.Exists)
                file.Delete();
        }

        public static bool FileExists(string filePath)
        {
            FileInfo file = new FileInfo(filePath);

            if (file.Exists)
                return true;

            return false;
        }

        public static string[] ParseOdbiorcy(string odbiorcy)
        {
            string[] wynik = odbiorcy.Split(';');


            return wynik;

        }
    }
}
