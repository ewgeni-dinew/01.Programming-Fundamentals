using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Num_Checker
{
    class Program
    {
        static void Main()
        {
            var inputNum = Console.ReadLine();
            long number;
            if (long.TryParse(inputNum,out number))
            {
                Console.WriteLine("integer");
            }
            else 
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
