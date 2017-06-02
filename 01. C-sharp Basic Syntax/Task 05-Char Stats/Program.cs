using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Char_Stats
{
    class Program
    {
        static void Main()
        {
            var inputName = Console.ReadLine();
            var inputFirstPart = int.Parse(Console.ReadLine());
            var inputFirstTotal = int.Parse(Console.ReadLine());
            var inputSecondPart = int.Parse(Console.ReadLine());
            var inputSecondTotal = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {inputName}");
            Console.WriteLine("Health: |"+new string('|',inputFirstPart)+new string('.',inputFirstTotal-inputFirstPart)+"|");
            Console.WriteLine("Energy: |"+new string('|',inputSecondPart)+new string('.',inputSecondTotal-inputSecondPart)+"|");

        }
    }
}
