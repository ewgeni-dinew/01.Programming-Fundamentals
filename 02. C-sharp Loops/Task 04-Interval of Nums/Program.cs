using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Interval_of_Nums
{
    class Program
    {
        static void Main()
        {
            var inputStart = int.Parse(Console.ReadLine());
            var inputEnd = int.Parse(Console.ReadLine());
            for (int i =Math.Min(inputStart,inputEnd); i <= Math.Max(inputEnd,inputStart); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
