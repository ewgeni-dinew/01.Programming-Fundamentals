using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_01_Extract_Emails
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that extracts all sentences that contain a particular word from a string (case-sensitive).

            var word = Console.ReadLine();

            var inputText = Console.ReadLine();

            var pattern = $@"(\w*[,-]*\s)*({word})\s(\s*\w*[,-]*)*";

            var sentences = Regex.Matches(inputText, pattern);

            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
