using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05_Count_Numbers
{
    class Program
    {
        static void Main()
        {
            //Task->Read a list of integers and find the longest sequence of equal elements. If several exist, print the leftmost.

            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            inputNumbers.Add(int.MaxValue);

            var longestSeq = new List<int>();
            var currentSeq = new List<int>();

            currentSeq.Add(inputNumbers[0]);

            for (int i = 1; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == currentSeq[0])
                {
                    currentSeq.Add(inputNumbers[i]);
                }
                else 
                {
                    if (longestSeq.Count < currentSeq.Count)
                    {
                        longestSeq.Clear();           
                        longestSeq.AddRange(currentSeq);
                    }
                    currentSeq.Clear();
                    currentSeq.Add(inputNumbers[i]);
                }
                
            }
            Console.WriteLine(string.Join(" ",longestSeq));
        }
    }
}
