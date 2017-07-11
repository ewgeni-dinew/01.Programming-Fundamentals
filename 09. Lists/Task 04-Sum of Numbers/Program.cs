using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Sum_of_Numbers
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that reads sequence of numbers, reverses their digits, and prints their sum.
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .ToList();

            int sum = 0;
       
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                string currentNum = inputNumbers[i];
                var reversedNum = string.Join("", currentNum.Reverse());
                int parsedNum = int.Parse(reversedNum);
                sum += parsedNum;
            }
            Console.WriteLine(sum);
            
        }
    }
}
