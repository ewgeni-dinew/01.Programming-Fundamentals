using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_Geometry_Calc
{
    class Program
    {
        public static double AreaOfFigure(string type)
        {
            if (type=="triangle")
            {
                var sideA= double.Parse(Console.ReadLine());
                var sideB= double.Parse(Console.ReadLine());
                return sideA * sideB / 2;
            }
            else if (type=="square")
            {
                var sideA = double.Parse(Console.ReadLine());
                return sideA * sideA;
            }
            else if (type=="rectangle")
            {
                var sideA = double.Parse(Console.ReadLine());
                var sideB = double.Parse(Console.ReadLine());
                return sideA * sideB ;
            }
            else if (type=="circle")
            {
                var sideA = double.Parse(Console.ReadLine());
                return Math.PI * sideA * sideA;
            }
            else
            {
                return 0;
            }            
        }
        static void Main()
        {
            var figureType = Console.ReadLine();
            Console.WriteLine($"{AreaOfFigure(figureType):f2}");

        }
    }
}
