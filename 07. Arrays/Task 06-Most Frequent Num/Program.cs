using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Most_Frequent_Num
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that finds the most frequent number in a given sequence of numbers.

            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(p=>p)
                .ToList();

            inputNums.Add(int.MaxValue);

            int currentCount = 1;
            int biggestCount = 1;
            int biggestNum = 0;

            var currentNum = new List<int>();

            currentNum.Add(inputNums[0]);

            for (int i = 1; i <inputNums.Count; i++)
            {
                if (currentNum[0]==inputNums[i])
                {
                    currentCount++;
                    
                }
                else
                {
                    if (currentCount>biggestCount)
                    {
                        biggestCount = currentCount;
                        biggestNum = currentNum[0];
                    }
                    currentCount = 1;
                    currentNum.Clear();
                    currentNum.Add(inputNums[i]);
                }
            }
            Console.WriteLine(biggestNum);
        }
    }
}
