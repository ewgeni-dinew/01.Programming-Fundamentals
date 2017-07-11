using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Fibunacci_Numbers
{
    class Program
    {
        public static int FibunacciNumber(int number)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            int sumOfTwoNums = 0;
            for (int i = 1; i <number; i++)
            {
               
                sumOfTwoNums = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sumOfTwoNums;
            }
            
            return sumOfTwoNums;
        }
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine(1);
            }
            else if(number==1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(FibunacciNumber(number));
            }
           
        }
    }
}
