using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_Cube_Properties
{
    class Program
    {
        public static double CubeProperties(double cubeSide, string type)
        {
            if (type == "volume")
            {
                return Math.Pow(cubeSide, 3);
            }
            else if (type == "face")
            {
                return Math.Sqrt(2) * cubeSide;
            }
            else if (type == "space")
            {
                return Math.Sqrt(3) * cubeSide;
            }
            else 
            {
                return Math.Pow(cubeSide, 2) * 6;
            }

        }
        static void Main()
        {
            var inputSizeOfCubeSide = double.Parse(Console.ReadLine());
            var inputType = Console.ReadLine();
            Console.WriteLine($"{CubeProperties(inputSizeOfCubeSide, inputType):f2}");
            
        }
    }
}
