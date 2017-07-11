using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Odd_Filter
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program, which receives an array of integers (space-separated), removes all the odd numbers, 
            //then converts the remaining numbers to odd numbers, based on these conditions:
            //*If the number is larger than the average of the collection of remaining numbers, add 1 to it.
            //*If the number is smaller than the average of the collection of remaining numbers, subtract 1 from it.
            //After you convert all of the elements to odd numbers, print them on the console(space - separated).

            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .ToList();

            var collectionAvg = inputNums.Average();

            foreach (var num in inputNums)
            {
                if (num>collectionAvg)
                {
                    Console.Write(num+1);
                }
                else
                {
                    Console.Write(num-1);
                }
                Console.Write(" ");
            }
        }
    }
}
