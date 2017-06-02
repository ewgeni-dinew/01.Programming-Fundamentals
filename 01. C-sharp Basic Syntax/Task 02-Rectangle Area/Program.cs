using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            var inputRectangleHeight = double.Parse(Console.ReadLine());
            var inputRectangleWidth = double.Parse(Console.ReadLine());
            var rectangleArea = inputRectangleWidth * inputRectangleHeight;
            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}
