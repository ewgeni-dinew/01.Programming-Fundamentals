using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Grab_and_Go
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program, which receives an array of integers and an integer as input. 
            //Find the last occurrence of the integer in the given array and print the sum of all elements before the number.

            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var searchedNum = int.Parse(Console.ReadLine());

            int sum = 0;
            bool occurence = false;

            for (int i = inputNums.Length-1; i >= 0; i--)
            {
                if (inputNums[i]==searchedNum)
                {
                    for (int j = 0; j <i; j++)
                    {                        
                        sum += inputNums[j];
                    }
                    occurence = true;
                    break;             
                }
            }
            if (occurence == true)
            {
                Console.WriteLine(sum);               
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
