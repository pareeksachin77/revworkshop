using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class RegexEmail
    {
        public static string Email = "^[A-Za-z0-9]+([._#][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
        public static bool validatestring(string Name)
        {
            return Regex.IsMatch(Name, Email);
        }
    }
}
