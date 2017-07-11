using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Min_Method
{
    class Program
    {
        static int GetMaxNumber(int firstNumber,int secondNumber, int thirdNumber)
        {
            var biggerNum = Math.Max(firstNumber, secondNumber);
            return Math.Max(biggerNum, thirdNumber);
        }
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMaxNumber(firstNumber,secondNumber,thirdNumber));
        }
    }
}
