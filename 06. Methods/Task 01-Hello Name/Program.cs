using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Hello_Name
{
    class Program
    {
        
       public static void PrintName(string inputName)
        {
            Console.WriteLine($"Hello, {inputName}!");
        }
        static void Main()
        {
            var inputName = Console.ReadLine();
            PrintName(inputName);
        }

    }
}
