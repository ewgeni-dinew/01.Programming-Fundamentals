using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Statistics
{
    class Program
    {

        static void Main()
        {
            //Task->Write a program which receives array of integers (space-separated) and prints the minimum and maximum number,
            // the sum of the elements and the average value.

            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Console.WriteLine($"Min = {ListMin(inputNums)}");
            Console.WriteLine($"Max = {ListMax(inputNums)}");
            Console.WriteLine($"Sum = {ListSum(inputNums)}");
            Console.WriteLine($"Average = {ListAverage(inputNums)}");
        }        

        public static int ListMin(List<int> listOfNums)
        {
            return listOfNums.Min();
        }
        public static int ListMax(List<int> listOfNums)
        {
            return listOfNums.Max();
        }
        public static int ListSum(List<int> listOfNums)
        {
            return listOfNums.Sum();
        }
        public static double ListAverage(List<int> listOfNums)
        {
            return listOfNums.Average();
        }
    }
}
