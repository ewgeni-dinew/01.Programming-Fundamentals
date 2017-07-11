using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Variable_In_Hex_Format
{
    class Program
    {
        static void Main()
        {
            string inputHexNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(inputHexNumber, 16));
        }
    }
}
