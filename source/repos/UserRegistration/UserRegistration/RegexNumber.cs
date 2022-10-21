using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class RegexNumber
    {
        /* for indian phone numbers: country code "91" followed by a whitespace and a 10 digit number
       starting from 6,7,8 or 9 */
        public static string Number = "^[9][1][ ][6-9][0-9]{9}$";
        public static bool validatestring(string name)
        {
            return Regex.IsMatch(name, Number);
        }
    }
}
