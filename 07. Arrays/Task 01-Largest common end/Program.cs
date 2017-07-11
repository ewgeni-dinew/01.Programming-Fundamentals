using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Largest_common_end
{
    class Program
    {
        static void Main()
        {
            //Task->Read two arrays of words and find the length of the largest common end (left or right).

            var firstInput = Console.ReadLine().Split(' ');
            var secondInput = Console.ReadLine().Split(' ');
            
            
            if (scanFromLeft(firstInput,secondInput)>scanFromRight(firstInput,secondInput))
            {
                Console.WriteLine(scanFromLeft(firstInput, secondInput));
            } 
            else
            {
                Console.WriteLine(scanFromRight(firstInput, secondInput));
            }
        }

        public static int scanFromRight(string[] first, string[] second)
        {
            int minLength = Math.Min(first.Length, second.Length);
            int count = 0;
            for (int i =0; i <minLength ; i++)
            {
                if (first[first.Length-1-i]==second[second.Length-i-1])
                {
                    count++;
                }
            }
            return count;
        }

        public static int scanFromLeft (string[] first, string[]second)
        {
            int minLength = Math.Min(first.Length, second.Length);
            int count = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (first[i] == second[i])
                {
                    count++;
                }
            }
            return count;
        } 
    }
}
