using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Sum_of_Chars
{
    class Program
    {
        static void Main()
        {
            var inputNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i= 0; i < inputNum; i++)
            {
                var currentWord = char.Parse(Console.ReadLine());
                sum += (int)currentWord;
            }
            Console.WriteLine("The sum equals: "+sum);
        }
    }
}
