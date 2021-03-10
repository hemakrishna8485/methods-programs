using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Reverse_of_a_number
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Reverses(12345));
        }
        public static int Reverses(int num)
        {
            int digit;
            int revnum = 0;
            while (num != 0)
            {
                digit = num % 10;
                num = num / 10;
                revnum = revnum * 10 + digit;
            }
            return revnum;
        }
    }
}
