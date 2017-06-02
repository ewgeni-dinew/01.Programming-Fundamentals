using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_X
{
    class Program
    {
        static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < (inputNumber-1)/2; i++)
            {
                Console.WriteLine(new string(' ', i) + "x" + new string(' ',inputNumber-2-2*i)+"x"+ new string(' ', i));
            }
            Console.WriteLine(new string(' ',(inputNumber-1)/2)+"x"+ new string(' ', (inputNumber - 1) / 2));
            for (int i = 0; i < (inputNumber - 1) / 2; i++)
            {
                Console.WriteLine(new string(' ',(inputNumber-3)/2-i) + "x" + new string(' ',2 * i+1) + "x" + new string(' ', (inputNumber - 3) / 2 - i));
            }
        }
    }
}
