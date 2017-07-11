using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Rotate_and_Sum
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program to read an array of n integers (space separated on a single line) and an integer k,
            //rotate the array right k times and sum the obtained arrays after each rotation as shown below.

            var inputValues = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            
            var parsedNumbers = new int[inputValues.Length];

            for (int i = 0; i < inputValues.Length ; i++)
            {
                parsedNumbers[i] = inputValues[i];
            }

            var index = int.Parse(Console.ReadLine());
            var sum = new int[parsedNumbers.Length];

            for (int i = 0; i < index; i++)
            {
                int lastNumber = parsedNumbers[parsedNumbers.Length - 1];
                for (int j  = parsedNumbers.Length-1; j  > 0; j --)
                {
                    parsedNumbers[j] = parsedNumbers[j - 1];
                }
                parsedNumbers[0] = lastNumber;
                for (int j = 0; j < parsedNumbers.Length; j++)
                {
                    sum[j] += parsedNumbers[j];
                }
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
