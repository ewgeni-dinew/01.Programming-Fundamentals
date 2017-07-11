using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03_CameraView
{
    class CameraView
    {
        static void Main()
        {
            //Task->On the first line, you will receive an array of integers with exactly two elements:
            //First element will be the ones, which you have to skip.The second element are the ones, which you have to take.
            //On the next line, you will receive a string, in which every camera will be marked with "|<".


            var inputNums = Console.ReadLine()
                .Split(' ');

            var pattern = @"(\|<\w+)";

            var inputText = Console.ReadLine();

            var skipNums = int.Parse(inputNums[0]);
            var takeNums = int.Parse(inputNums[1]);

            var matchedNums = new List<string>();

            MatchCollection matches = Regex.Matches(inputText, pattern);

            foreach (Match match in matches)
            {
                matchedNums.Add(string.Join("", match.Value.
                    Skip(skipNums + 2)
                    .Take(takeNums)
                    .ToArray()));
            }

            Console.WriteLine(string.Join(", ", matchedNums));
        }
    }
}