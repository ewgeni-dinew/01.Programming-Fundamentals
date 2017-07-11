using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Censorship
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program, which takes as an input a single word and a sentence. 
            //Your program should search for the word in the sentence and replace every letter of the word with '*'.

            var censorWord = Console.ReadLine();

            var inputText = Console.ReadLine();

            var result = inputText.Replace(censorWord, new string('*', censorWord.Length));

            Console.WriteLine(result);
        }
    }
}
