using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Catch_the_thief
{
    class Program
    {
        static void Main()
        {
            var dataType = Console.ReadLine();
            var amount = int.Parse(Console.ReadLine());
            long smallestDiff = long.MaxValue;
            long smallestNum = 0;
            for (int i = 0; i < amount; i++)
            {
                var currentNum = long.Parse(Console.ReadLine());
                if (dataType == "sbyte")
                {
                    var difference = Math.Abs(sbyte.MaxValue - currentNum);
                    if (difference<smallestDiff)
                    {
                        smallestDiff = difference;
                        smallestNum = currentNum;
                    }
                }
                else if (dataType == "int")
                {
                    var difference = Math.Abs(int.MaxValue - currentNum);
                    if (difference < smallestDiff)
                    {
                        smallestDiff = difference;
                        smallestNum = currentNum;
                    }
                }
                else if (dataType == "long")
                {
                    var difference = Math.Abs(long.MaxValue - currentNum);
                    if (difference < smallestDiff)
                    {
                        smallestDiff = difference;
                        smallestNum = currentNum;
                    }
                }
            }
            Console.WriteLine(smallestNum);
        }
    }
}
