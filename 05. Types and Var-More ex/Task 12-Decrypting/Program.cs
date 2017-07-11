using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_Decrypting
{
    class Program
    {
        static void Main()
        {
            var key = int.Parse(Console.ReadLine());
            var inputNum = int.Parse(Console.ReadLine());
            var newWord = new List<char>();
            for (int i = 0; i < inputNum; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());
                var nextWord = (char)((int)currentChar + key);
                newWord.Add(nextWord);
            }
            Console.WriteLine(string.Join("",newWord)); 
        }
    }
}
