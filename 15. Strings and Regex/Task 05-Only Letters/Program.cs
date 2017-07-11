using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program which takes a string message as input and replaces all numbers with the letter immediately afterthe number.
        
            var inputText = Console.ReadLine();
            var matches = Regex.Matches(inputText, @"(\d+)([a-zA-Z])");

            foreach (Match match in matches)
            {
                inputText = Regex.Replace(inputText, $@"{match.Groups[1].Value}", $@"{match.Groups[2].Value}");
            }

            Console.WriteLine(inputText);
        }
    }
}