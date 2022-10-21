using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class PasswordRuleFour
    {
        public static string passwordfour = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^?*&%$#@!]*[?*&%$#@!][^?*&%$#@!]*$).{8,}$";
        public static bool validateString(string name)
        {
            return Regex.IsMatch(name, passwordfour);
        }
    }
}
