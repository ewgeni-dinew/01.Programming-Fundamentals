using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Byte_Flip
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program, which receives a string array, containing bytes in hexadecimal format with the digits reversed.
            //Your task is to remove any elements whose length is different than 2, then reverse the digits in every number,
            //and finally reverse the whole collection and convert every element from hexadecimal numbers to characters from the ASCII table.

            var inputValue = Console.ReadLine()
                .Split(' ')
                .Where(w => w.Length == 2)
                .Reverse()
                .ToList();

            var reversedList = new List<char>();

            for (int i = 0; i <inputValue.Count; i++)
            {
                var currentNum = inputValue[i].ToCharArray();
                foreach (var digit in currentNum.Reverse())
                {
                    reversedList.Add(digit);
                }
                string joinedSymbols = string.Join("", reversedList);

                Console.Write(ReturnCharFromHex(joinedSymbols));
                
                reversedList.Clear();
            }         
        }

        public static char ReturnCharFromHex(string symbols)
        {
            return (char)Int16.Parse(symbols, NumberStyles.AllowHexSpecifier);
        }
    }
}
