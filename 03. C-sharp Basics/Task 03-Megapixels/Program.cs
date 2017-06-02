using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Megapixels
{
    class Program
    {
        static void Main()
        {
            var inputWidth = double.Parse(Console.ReadLine());
            var inputHeight = double.Parse(Console.ReadLine());
            double megapixels = Math.Round(inputHeight * inputWidth / 1000000,1);
            Console.WriteLine($"{inputWidth}x{inputHeight} => {megapixels}MP");
        }
    }
}
