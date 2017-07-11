using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Increasing_Max_Seq
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that finds the longest increasing subsequence in an array of integers.
            //The longest increasing subsequence is a portion of the array (subsequence)
            //that is strongly increasing and has the longest possible length.
            //If several such subsequences exist, find the left most of them.

            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            inputNums.Add(int.MinValue);

            int currentNum = inputNums[0];
            var currentSeq = new List<int>();
            var longestSeq = new List<int>();

            currentSeq.Add(inputNums[0]);

            for (int i = 1; i < inputNums.Count; i++)
            {
                if (currentNum<inputNums[i])
                {
                    currentSeq.Add(inputNums[i]);
                }
                else
                {
                    if (currentSeq.Count>longestSeq.Count)
                    {
                        longestSeq.Clear();
                        longestSeq.AddRange(currentSeq);
                    }
                    currentSeq.Clear();
                    currentSeq.Add(inputNums[i]);
                }
                currentNum = inputNums[i];
            }
            Console.WriteLine(string.Join(" ",longestSeq));

        }
    }
}
