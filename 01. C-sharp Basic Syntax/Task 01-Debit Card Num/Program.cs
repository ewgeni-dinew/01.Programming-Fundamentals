using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Debit_Card_Num
{
    class Program
    {
        static void Main()
        {
            var inputFirstNum = int.Parse(Console.ReadLine());
            var inputSecondNum= int.Parse(Console.ReadLine());
            var inputThirdNum = int.Parse(Console.ReadLine());
            var inputForthNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inputFirstNum:d4} {inputSecondNum:d4} {inputThirdNum:d4} {inputForthNum:d4}");
        }
    }
}
