using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_House_Builder
{
    class Program
    {
        static void Main()
        {
            var inputFirstValue = long.Parse(Console.ReadLine());
            var inputSecondValue = long.Parse(Console.ReadLine());
            long sum = 0;
            if (inputFirstValue>=sbyte.MinValue&&inputFirstValue<=sbyte.MaxValue)
            {
                sum = 4 * inputFirstValue + 10 * inputSecondValue;
            }
            else
            {
                sum = 10 * inputFirstValue + 4 * inputSecondValue;
            }
            Console.WriteLine(sum);
        }
    }
}
