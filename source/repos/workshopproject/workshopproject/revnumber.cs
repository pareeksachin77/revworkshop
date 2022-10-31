using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshopproject
{
    internal class revnumber
    {
        public static void rev()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversenumber = 0;
            int temp = 0;

            while(num > 0)
            {
                temp = num % 10;
                num =num / 10;
                reversenumber = reversenumber * 10 + temp;
            }

            Console.WriteLine("reverse number is" + reversenumber);
        }
    }
}
