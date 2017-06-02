using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_Integers_Count
{
    class Program
    {
        static void Main()
        {
            var inputValue = Console.ReadLine();
            int value;
            int count = 0;
            while (int.TryParse(inputValue, out value))
            {
                count++;
                inputValue = Console.ReadLine();
            }
            Console.WriteLine(count);
        }
    }
}
