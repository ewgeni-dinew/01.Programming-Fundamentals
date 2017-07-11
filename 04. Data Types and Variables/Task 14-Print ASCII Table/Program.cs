using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Print_ASCII_Table
{
    class Program
    {
        static void Main()
        {

            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());
            for (decimal Loop = firstNum; Loop <= secondNum; Loop++)
            {
                Console.Write("{0} ", (char)Loop);

            }
        }
    }
}
