using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09_Word
{
    class Program
    {
        static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var wordArray = new List<string>();
            for (int i = 0; i < inputNumber; i++)
            {
                var currentWord = Console.ReadLine();
                wordArray.Add(currentWord);
            }
            Console.WriteLine("The word is: "+string.Join("",wordArray));
        }
    }
}
