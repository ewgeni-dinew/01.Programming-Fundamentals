using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Compare_Chars
{
    class Program
    {
        static void Main()
        {
            //Task->Compare two char arrays lexicographically (letter by letter).
            //Print the them in alphabetical order, each on separate line.

            var inputFirstLine = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            var inputSecondLine = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            for (int i = 0; i < Math.Min(inputFirstLine.Length,inputSecondLine.Length); i++)
            {

                if ((int)inputFirstLine[i]<(int)inputSecondLine[i])
                {
                    Console.WriteLine(string.Join("",inputFirstLine));
                    Console.WriteLine(string.Join("", inputSecondLine));
                    break;
                }
                else if ((int)inputFirstLine[i] > (int)inputSecondLine[i])
                {
                    Console.WriteLine(string.Join("", inputSecondLine));
                    Console.WriteLine(string.Join("", inputFirstLine));
                    break;
                }
                else if (i== Math.Min(inputFirstLine.Length, inputSecondLine.Length)-1)
                {
                    if (inputFirstLine.Length >inputSecondLine.Length)
                    {
                        Console.WriteLine(string.Join("", inputSecondLine));
                        Console.WriteLine(string.Join("", inputFirstLine));
                        
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", inputSecondLine));
                        Console.WriteLine(string.Join("", inputFirstLine));
                        break;
                    }
                }
            }
        }
    }
}
