using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int newValueNumber = 0;
            Console.WriteLine("Before: \n a = {0} \n b = {1}",firstNumber,secondNumber);
            newValueNumber += firstNumber;
            firstNumber = secondNumber;
            Console.WriteLine("After: \n a = {0} \n b = {1}", firstNumber, newValueNumber);

        }
    }
}
