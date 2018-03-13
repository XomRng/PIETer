using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = System.DateTime;

namespace DataModels
{
    public static class StringExtensions
    {
        public static DateTime ToDateTime(this string str)
        {
            int irok, imiesiac, idzien;
            string rok = "", miesiac = "", dzien = "";
            DateTime data;

            if (str.Length == 10 || str.Length == 19)
            {              
                int index = 0;
                foreach (var c in str)
                {                   
                    if (index < 4) rok += c;
                    if (index < 7 && index > 4) miesiac += c;
                    if (index >= 8 && index <= 10) dzien += c;
                    if (index >= 10) break;
                    index++;                  
                }                            
            }
            
            try
            {
                irok = Convert.ToInt32(rok);
                imiesiac = Convert.ToInt32(miesiac);
                idzien = Convert.ToInt32(dzien);
                data = new DateTime(irok, imiesiac, idzien);
            }
            catch (Exception)
            {
                data = new DateTime(1800, 01, 01);
            }
            return data;
        }

        public static string RemoveWhitespace(this string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "";

            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }


        public static int ToInt32(this string input)
        {
            int result;
            try
            {
                result = Convert.ToInt32(input);
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
            
            
        }

        public static string Left(this string input, int letters)
        {
            if(letters < 0 || letters > input.Length)
                throw new InvalidDataException();
            
            string result = "";
            var charTable = input.ToCharArray();
            for (var i = 0; i < letters; i++)
            {
                result += charTable[i];
            }

            return result;
        }
    }
}
