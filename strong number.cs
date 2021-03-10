using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class strong_number
    {
        static void Main(string[] args)
        {
            int num, sum = 0, rem, temp;
            Console.WriteLine("Enter any number :");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                int fact = 1;
                for (int i = 1; i <= rem; i++)
                {
                    fact = fact * 1;
                }
                sum = sum + fact;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is Strong");
            }


            else

            {
                Console.WriteLine("Number is not a Strong");
            }
        }
    }
}