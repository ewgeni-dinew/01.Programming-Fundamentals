using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Test_Nums
{
    class Program
    {
        static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var borderNum = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;

            for (int i = firstNum; i > 0; i--)
            {
                for (int j = 1; j <=secondNum; j++)
                {
                    count++;
                    sum += 3 * (j*i);
                    if (sum>=borderNum)
                    {
                        break;
                    }
                    
                }
                if (sum >= borderNum)
                {
                    break;
                }
            }
            Console.WriteLine($"{count} combinations");
            if (sum >= borderNum)
            {
                Console.WriteLine($"Sum: {sum} >= {borderNum}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
