using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Water_Overflow
{
    class Program
    {
        static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            int pouredLitres = 0;
            int tankLitres = 255;

            for (int i = 0; i < inputNumber; i++)
            {
                
                var currentNum = int.Parse(Console.ReadLine());
                if (currentNum>tankLitres)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    pouredLitres += currentNum;
                    tankLitres -= currentNum;
                }
            }
            Console.WriteLine(pouredLitres);
        }
    }
}
