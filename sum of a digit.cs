using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class sum_of_a_digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(12554));
        }

        private static int SumDigits(int v)
        {
            int Sum = 0;
            while (v > 0)
            {

                Sum += v % 10;
                v /= 10;
            }
            return Sum;
        }
    }
}
