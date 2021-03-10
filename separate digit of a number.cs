using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class separate_digit_of_a_number
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SepDigit(123));
        }
        public static string SepDigit(int num)
        {
            string str = string.Empty;
            while (num != 0)
            {
                str = str + num % 10 + "  \n  ";
                num = num / 10;
            }
            return str;
        }
    }
}


