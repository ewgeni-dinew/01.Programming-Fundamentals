using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Tourist_Info
{
    class Program
    {
        static void Main()
        {
            var inputRangeType = Console.ReadLine();
            var ammount = double.Parse(Console.ReadLine());
            if (inputRangeType=="miles")
            {
                Console.WriteLine($"{ammount} miles = {(ammount * 1.6):f2} kilometers");
            }
            else if (inputRangeType=="inches")
            {
                Console.WriteLine($"{ammount} inches = {(ammount*2.54):f2} centimeters");
            }
            else if (inputRangeType == "feet")
            {
                Console.WriteLine($"{ammount} feet = {(ammount * 30):f2} centimeters");
            }
            else if (inputRangeType == "yards")
            {
                Console.WriteLine($"{ammount} yards = {(ammount * 0.91):f2} meters");
            }
            else if (inputRangeType == "gallons")
            {
                Console.WriteLine($"{ammount} gallons = {(ammount * 3.8):f2} liters");
            }
        }
    }
}
