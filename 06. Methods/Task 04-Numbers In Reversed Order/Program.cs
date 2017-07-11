using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Numbers_In_Reversed_Order
{
    class Program
    {
        static string InputNumber(double number)
        {
            var numString = number.ToString();
            var reversedString = string.Empty;
            for (int i = numString.Length-1; i >= 0; i--)
            {
                reversedString += numString[i];
            }
            return reversedString;
        }
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            Console.WriteLine(InputNumber(number));
        }
    }
}
