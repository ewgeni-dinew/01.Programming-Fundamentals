

namespace Task_11_Integer_To_Hex_And_Binary
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Convert.ToString(inputNumber,16).ToUpper());
            Console.WriteLine(Convert.ToString(inputNumber,2));
        }
    }
}
