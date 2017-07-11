using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Fold_and_Sum
{
    class Program
    {
        static void Main()
            {
            //Task->Read an array of 4*k integers, fold it like shown below 
            //and print the sum of the upper and lower two rows (each holding 2 * k integers)

            var inputValues = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

           
            var firstQuarterNums = new int[inputValues.Length /4];
            var secondQuarterNums = new int[inputValues.Length / 4];
            var thirdQuarterNums = new int[inputValues.Length / 4];
            var lastQuarterNums = new int[inputValues.Length / 4];

            var resultFirstHalf = new int[inputValues.Length/4];
            var resultSecondHalf = new int[inputValues.Length/4];

            for (int i = 0; i < inputValues.Length/4; i++)
            {
                firstQuarterNums[i] = inputValues[inputValues.Length/4-i-1];
            }
            for (int m = 0; m < inputValues.Length/4; m++)
            {
                secondQuarterNums[m] = inputValues[inputValues.Length/ 4 + m];
            }
            for (int n = 0; n < inputValues.Length / 4; n++)
            {
                thirdQuarterNums[n] = inputValues[inputValues.Length / 2 + n];
            }
            for (int j = 0; j < inputValues.Length/4; j++)
            {
                lastQuarterNums[j] = inputValues[inputValues.Length-1-j];
            }
            for (int l = 0; l < inputValues.Length/4; l++)
            {
                resultFirstHalf[l] = firstQuarterNums[l] + secondQuarterNums[l];
            }
            for (int p = 0; p < inputValues.Length / 4; p++)
            {
                resultSecondHalf[p] = thirdQuarterNums[p] + lastQuarterNums[p];
            }

            Console.Write(string.Join(" ",resultFirstHalf)+" ");
            Console.WriteLine(string.Join(" ",resultSecondHalf));
        }
    }
}
