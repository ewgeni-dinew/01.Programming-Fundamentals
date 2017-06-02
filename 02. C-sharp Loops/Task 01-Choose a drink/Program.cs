using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Choose_a_drink
{
    class Program
    {
        static void Main()
        {
            var inputValue = Console.ReadLine();
            var inputQuantities = double.Parse(Console.ReadLine());

            if (inputValue=="Athlete")
            {
                Console.WriteLine($"The {inputValue} has to pay {(inputQuantities*0.7):f2}."); 
            }
            else if (inputValue=="Businessman"||inputValue=="Businesswoman")
            {
                Console.WriteLine($"The {inputValue} has to pay {(inputQuantities * 1.0):f2}.");
            }
            else if (inputValue=="SoftUni Student")
            {
                Console.WriteLine($"The {inputValue} has to pay {(inputQuantities * 1.7):f2}.");
            }
            else 
            {
                Console.WriteLine($"The {inputValue} has to pay {(inputQuantities * 1.2):f2}.");
            }
        }
    }
}
