using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Type_Boundaries
{
    class Program
    {
        static void Main()
        {
            var inputType = Console.ReadLine();
            if (inputType=="int")
            {
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);
            }
            else if (inputType=="uint")
            {
                Console.WriteLine(uint.MaxValue);
                Console.WriteLine(uint.MinValue);
            }
            else if (inputType == "long")
            {
                Console.WriteLine(long.MaxValue);
                Console.WriteLine(long.MinValue);
            }
            else if (inputType == "byte")
            {
                Console.WriteLine(byte.MaxValue);
                Console.WriteLine(byte.MinValue);
            }
            else if (inputType == "sbyte")
            {
                Console.WriteLine(sbyte.MaxValue);
                Console.WriteLine(sbyte.MinValue);
            }
        }
    }
}
