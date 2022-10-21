using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class RegexLastname
    {
        public static string Lastname = "^[A-z][1][a-z]{2,0}$";

        public static bool validatestring(String Name)
        {
            return Regex.IsMatch(Name, Lastname);
        }

    }
}
