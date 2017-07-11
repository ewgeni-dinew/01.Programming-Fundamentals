using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Sort_Times
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program, which receives a list of times (space-separated, 24-hour format)
            //and sorts them in ascending order.Print the sorted times comma - separated.

            var inputTimes = Console.ReadLine()
                .Split(' ')
                .OrderBy(t => t)
                .ToList();

            Console.WriteLine(string.Join(", ",inputTimes));
            
        }
    }
}
