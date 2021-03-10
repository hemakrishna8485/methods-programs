using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class averagenumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitAverage(88));
        }
        public static double DigitAverage(int num)
        {
            int count = 0;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                count++;
                sum = sum + digit;
                num = num / 10;
            }
            double avg = sum / count;
            return avg;
        }
    }
}
        
   
