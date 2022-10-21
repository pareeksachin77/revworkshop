using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class RegexFirstName
    {

        public static string FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public static bool validatestring(String Name)
        {
            return Regex.IsMatch(Name, FirstName);
        }
    }
}
