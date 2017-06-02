using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Cake_ingredients
{
    class Program
    {
        static void Main()
        {
            var inputValue = Console.ReadLine();
            int count = 0;
            while (inputValue!="Bake!")
            {
                count++;
                Console.WriteLine("Adding ingredient {0}.",inputValue);
               
                inputValue = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
