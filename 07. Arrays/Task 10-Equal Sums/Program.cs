using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that determines if there exists an element in the array such that the sum of the elements on its
            //left is equal to the sum of the elements on its right.If there are no elements to the left/right,
            //their sum is considered to be 0.Print the index that satisfies the required condition or “no” if there is no such index.


            var inputNums = Console.ReadLine()
                .Split().
                Select(int.Parse).
                ToArray();


            for (int i = 1; i <= inputNums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += inputNums[j];
                }

                for (int j = i + 1; j < inputNums.Length; j++)
                {
                    rightSum += inputNums[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (inputNums.Length == 1)
                {
                    Console.WriteLine("0");
                }
                else if (leftSum != rightSum && i == inputNums.Length)
                {
                    Console.WriteLine("no");
                }

            }
        }
    }
}