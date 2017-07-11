using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_English_Name_of_Last_Digit
{
    class Program
    {
        public static void InputNumber(long number)
        {
            var lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("zero");break;
                case  1:
                    Console.WriteLine("one");break;
                case 2:
                    Console.WriteLine("two");break;
                case 3:
                    Console.WriteLine("three"); break;
                case 4:
                    Console.WriteLine("four"); break;
                case 5:
                    Console.WriteLine("five"); break;
                case 6:
                    Console.WriteLine("six"); break;
                case 7:
                    Console.WriteLine("seven"); break;
                case 8:
                    Console.WriteLine("eight"); break;
                case 9:
                    Console.WriteLine("nine");break;
            }
        }
        static void Main()
        {
            
            var inputNumber = long.Parse(Console.ReadLine());
            if (inputNumber < 0)
            {
                inputNumber = Math.Abs(inputNumber);
                InputNumber(inputNumber);
            }
            else
            {
                InputNumber(inputNumber);
            }            
        }
    }
}
