using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIETer
{
    public static class Extensions
    {
        public static bool IsNumeric(this string testedString)
        {
            var characters = testedString.ToCharArray();
            foreach (char character in characters)
            {
                if (!Char.IsNumber(character))
                    return false;
            }
            return true;

        }
    }
}
