using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_Rectangle_Properties
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = width * 2 + height * 2;
            double area = width * height;
            double diagonal = Math.Sqrt(width*width+height*height);
            Console.WriteLine($" {perimeter} \n{area} \n{diagonal}");
        }
    }
}
