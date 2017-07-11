using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Char_Multip
{
    class Program
    {
        static void Main()
        {
            //Task->Create a program that takes two strings as arguments and returns the sum of their character codes multiplied.
            //Multiply str1.charAt (0) with str2.charAt (0) and add to the total sum. 
            //Then continue with the next two characters.
            //If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.


            var input = Console.ReadLine()
                .Split(' ');
            var firstString = input[0];
            var secondString = input[1];
            int sum = 0;

            if (firstString.Length!=secondString.Length)
            {
                for (int i = 0; i < Math.Min(firstString.Length,secondString.Length); i++)
                {
                    sum += firstString[i] * secondString[i];
                }
                for (int i = Math.Min(firstString.Length, secondString.Length); i < BiggerString(firstString, secondString).Length; i++)
                {
                    sum += BiggerString(firstString, secondString)[i];
                }
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }
            }
            Console.WriteLine(sum);
        }

        public static string BiggerString(string A,string B)
        {
            if (A.Length>B.Length)
            {
                return A;
            }
            else
            {
                return B;
            }
        }
    }
}
