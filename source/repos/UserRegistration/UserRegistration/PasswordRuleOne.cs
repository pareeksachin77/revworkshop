using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class PasswordRuleOne
    {
        public static string Paswword1 = "^[a-zA-Z0-9]{8,}$";
        public static bool validateString(string name)
        {
            return Regex.IsMatch(name, Paswword1);
        }
    }
}
