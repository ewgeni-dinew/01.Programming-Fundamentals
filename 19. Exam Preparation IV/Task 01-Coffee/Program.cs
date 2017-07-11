using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Coffee
{
    class Program
    {
        static void Main()
        {
            var orderCount = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < orderCount; i++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());
                var orderDate = Console.ReadLine().Split('/');
                var month = int.Parse(orderDate[1]);
                var year = int.Parse(orderDate[2]);
                var capsulesCount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(year,month);

                var currentOrder = daysInMonth * capsulesCount * capsulePrice;

                Console.WriteLine($"The price for the coffee is: ${currentOrder:f2}");
                total += currentOrder;
            }
            Console.WriteLine($"Total: ${total:f2}");

        }
    }
}
