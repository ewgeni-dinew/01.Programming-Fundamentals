using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_PokemonGo
{
    class Program
    {
        static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            long removedNums = 0;

            while (inputNums.Count != 0)
            {
                var currentIndex = int.Parse(Console.ReadLine());
                var removedNum = 0;

                if (currentIndex < 0)
                {
                    removedNum = inputNums[0];
                    var removeFirst = inputNums.Skip(1).ToList();
                    var last = inputNums[inputNums.Count - 1];
                    inputNums.Clear();
                    inputNums.Add(last);
                    inputNums.AddRange(removeFirst);
                    
                }
                else if (currentIndex > inputNums.Count - 1)
                {
                    removedNum = inputNums.Last();
                    var first = inputNums[0];
                    inputNums.RemoveAt(inputNums.Count - 1);
                    inputNums.Add(first);
                 
                }
                else
                {
                    removedNum = inputNums[currentIndex];
                    inputNums.RemoveAt(currentIndex);
                }

                
                for (int i = 0; i < inputNums.Count; i++)
                {
                    if (inputNums[i] <= removedNum)
                    {
                        inputNums[i] += removedNum;
                    }
                    else if (inputNums[i] > removedNum)
                    {
                        inputNums[i] -= removedNum;
                    }
                }
                removedNums += removedNum;
            }
            Console.WriteLine(removedNums);
        }
    }
}
