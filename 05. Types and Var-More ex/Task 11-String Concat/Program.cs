using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_String_Concat
{
    class Program
    {
        static void Main()
        {
            var symbol =(Console.ReadLine());
            var type = Console.ReadLine();
            var listNums = new List<string>();
            var inputNum = int.Parse(Console.ReadLine());

            if (type == "odd")
            {
                for (int i = 1; i <= inputNum; i++)
                {
                    var currentWord = Console.ReadLine();
                    if (i%2!=0)
                    {
                        listNums.Add(currentWord);
                    }
                }
                Console.WriteLine(string.Join(symbol,listNums));
            }
            else
            {
                for (int i = 1; i <= inputNum; i++)
                {
                    var currentWord = Console.ReadLine();
                    if (i % 2 == 0)
                    {
                        listNums.Add(currentWord);
                    }
                }
                Console.WriteLine(string.Join(symbol, listNums));
            }  
        }
    }
}
