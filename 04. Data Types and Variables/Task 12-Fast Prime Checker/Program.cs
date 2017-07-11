using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Fast_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int firstLoop = 2; firstLoop <= inputNumber; firstLoop++)
            {
                bool Truth = true;
                for (int secondLoop = 2; secondLoop <= Math.Sqrt(firstLoop); secondLoop++)
                {
                    if (firstLoop%secondLoop==0)
                    {
                        Truth = false;
                        break;
                    }
                }
                Console.WriteLine($"{firstLoop} -> {Truth}");
            }
        }
    }
}
