using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class separate_factors_of_a_number
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(Separatefact(12));
            }

            Console.WriteLine(Separatefact(12));
        }

        private static string Separatefact(int v)
        {
            string fact = string.Empty;
            for (int i = 1; i <= v; i++)
            {
                if (v % i == 0)
                {
                    fact += i + "\n";
                }
            }
            return fact;
        }
    }
}