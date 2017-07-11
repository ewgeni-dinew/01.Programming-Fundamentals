using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_04_RegexMon
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            while (true)
            {
                var didimonMatch = Regex.Match(input, @"(?<one>[a-zA-Z]+\-[a-zA-Z]+)*(?<chars>[^-a-zA-Z]+)(?<two>[a-zA-Z]+\-[a-zA-Z]+)*");
                if (didimonMatch.Success)
                {
                    var match = new string(didimonMatch.Groups["chars"].Value.ToArray());
                    var first = new string(didimonMatch.Groups["one"].Value.ToArray());
                    var second = new string(didimonMatch.Groups["two"].Value.ToArray());
                    input = string.Empty;
                    input = first + second;
                    Console.WriteLine(match);
                }
                else if (!didimonMatch.Success)
                {
                    break;
                }

                var bojomonMatch = Regex.Match(input, @"(?<one>[^-a-zA-Z]+)*(?<words>[a-zA-Z]+\-[a-zA-Z]+)(?<two>[^-a-zA-Z]+)*");

                if (bojomonMatch.Success)
                {
                    var match = new string(bojomonMatch.Groups["words"].Value.ToArray());
                    var first= new string(bojomonMatch.Groups["one"].Value.ToArray());
                    var second= new string(bojomonMatch.Groups["two"].Value.ToArray());
                    input = string.Empty;
                    input = first + second;
                    Console.WriteLine(match);
                }
                else if (!bojomonMatch.Success)
                {
                    break;
                }
            }
        }
    }
}
