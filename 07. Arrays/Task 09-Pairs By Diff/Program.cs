using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_Pairs_By_Diff
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that count the number of pairs in given array which difference is equal to given number.
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var inputDifference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < inputNums.Length; i++)
            {
                for (int j = i; j < inputNums.Length; j++)
                {
                    if (Math.Max(inputNums[i],inputNums[j])-Math.Min(inputNums[i],inputNums[j]) == inputDifference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
