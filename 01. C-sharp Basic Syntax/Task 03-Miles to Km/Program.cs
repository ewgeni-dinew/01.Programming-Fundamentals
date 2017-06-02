using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Miles_to_Km
{
    class Program
    {
        static void Main()
        {
            var inputMiles = double.Parse(Console.ReadLine());
            var kilometres = inputMiles * 1.60934;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
