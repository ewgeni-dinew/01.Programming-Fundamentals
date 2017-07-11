using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Prime_Checker
{
    class Program
    {
        public static bool PrimeNumber(long number)
        {
            bool prime = true;
            if (number == 1 || number == 0)
            {
                return false;
            }

            for (int m = 2; m <= Math.Sqrt(number); m++)
                    {
                        if (number % m == 0)
                        {
                            prime = false;
                        }
                    }
               
                return prime;
            
        }
        static void Main()
        {
            long number = long.Parse(Console.ReadLine()); 
                Console.WriteLine(PrimeNumber(number));
           
        }
    }
}
