using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class given_a_factor_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factors(12));
        }
        public static int factors(int num)
        {
            int count = 0;
            int i;
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
