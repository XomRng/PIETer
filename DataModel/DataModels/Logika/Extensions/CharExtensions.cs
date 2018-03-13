using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public static class CharExtensions
    {
        public static string ToString(this IEnumerable<char> c)
        {
            

            string result = "";
            foreach (var c1 in c)
            {
                result += c1;
            }
            return result;
        }
    }
}
