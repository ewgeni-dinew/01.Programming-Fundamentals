using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Max_Sequence
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that finds the longest sequence of equal elements in an array of integers. 
            //If several longest sequences exist, print the leftmost one.

            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            inputNums.Add(int.MaxValue);
          

            var currentSequenceOfNums = new List<int>();
            var biggestSequenceOfNums = new List<int>();

            currentSequenceOfNums.Add(inputNums[0]);

            for (int i = 1; i < inputNums.Count; i++)
            { 
                if (currentSequenceOfNums[0]==inputNums[i])
                {
                    currentSequenceOfNums.Add(inputNums[i]); 
                }
                else
                {
                    if (currentSequenceOfNums.Count > biggestSequenceOfNums.Count)
                    {
                        biggestSequenceOfNums.Clear();
                        biggestSequenceOfNums.AddRange(currentSequenceOfNums);
                    }
                    currentSequenceOfNums.Clear();
                    currentSequenceOfNums.Add(inputNums[i]);
                }
            }
            Console.WriteLine(string.Join(" ",biggestSequenceOfNums));
        }
    }
}
