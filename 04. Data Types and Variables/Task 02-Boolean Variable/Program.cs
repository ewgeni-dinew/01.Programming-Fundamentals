using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Boolean_Variable
{
    class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            if (Convert.ToBoolean(inputText)==true)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }
    }
}
