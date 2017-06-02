using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Word_in_Plural
{
    class Program
    {
        static void Main()
        {
            string inputWord = Console.ReadLine();
            var wordArray = inputWord.ToList();
            if (inputWord.EndsWith("y"))
            {
                wordArray.RemoveAt(wordArray.Count - 1);
                wordArray.Add('i');
                wordArray.Add('e');
                wordArray.Add('s');
                Console.WriteLine(string.Join("",wordArray));
            }
            else if (inputWord.EndsWith("o")|| inputWord.EndsWith("ch")||inputWord.EndsWith("x")|| inputWord.EndsWith("z")|| inputWord.EndsWith("s")|| inputWord.EndsWith("sh"))
            {
                wordArray.Add('e');
                wordArray.Add('s');
                Console.WriteLine(string.Join("",wordArray));
            }
            else
            {
                wordArray.Add('s');
                Console.WriteLine(string.Join("", wordArray));
            }
        }
    }
}
