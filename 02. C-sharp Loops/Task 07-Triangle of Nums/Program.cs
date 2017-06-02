using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Triangle_of_Nums
{
    class Program
    {
        static void Main()
        {
            var inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <=inputNum; i++)
            {
                for (int j = 1;  j < i+1;  j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
