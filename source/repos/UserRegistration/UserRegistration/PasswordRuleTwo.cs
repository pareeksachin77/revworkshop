using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class PasswordRuleTwo
    {
        public static string Password2 = "^(?=.*[A-Z]).{8,}$";
        public static bool validateString(string name)
        {
            return Regex.IsMatch(name,Password2);
        }
    }
}
