using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_Index_Of_Letters
{
    class Program
    {
        static void Main()
        {
            var inputWord = Console.ReadLine()
                .ToCharArray();

            for (int i = 0; i <inputWord.Length; i++)
            {
                var currentNum = (int)inputWord[i] - 97;
                Console.WriteLine($"{inputWord[i]} -> {currentNum}");
            }
        }
    }
}
