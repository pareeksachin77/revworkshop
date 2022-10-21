using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace UserRegistration
{
    internal class EmailSample
    {
        public static string Semail = @"^[A-Za-z0-9+.-]{3,}[@][A_Za-z0-9]+[.][a-z]{2,}([.][a-z]{2})?$";
        public static bool validateString(string name)
        {
            return Regex.IsMatch(name, Semail);
        }
    }
}
