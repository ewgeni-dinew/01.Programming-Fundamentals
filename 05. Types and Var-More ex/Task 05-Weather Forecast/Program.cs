using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Weather_Forecast
{
    class Program
    {
        static void Main()
        {
            var inputNum =Console.ReadLine();
            long number;
            if (long.TryParse(inputNum, out number))
            {
                
                var parsedNum = long.Parse(inputNum);
                if (parsedNum >= sbyte.MinValue && parsedNum <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (parsedNum >= int.MinValue && parsedNum <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (parsedNum >= long.MinValue && parsedNum <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
