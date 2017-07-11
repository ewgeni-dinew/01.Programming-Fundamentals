using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Unicode_Chars
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that converts a string to a sequence of Unicode character literals.

            var inputString = Console.ReadLine();

            var chars = inputString
                .Select(c => (int)c)
                .Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);
            Console.WriteLine(result);
        }
    }
}
