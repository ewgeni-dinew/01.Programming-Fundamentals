using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Library_Mod
{
    class Program
    {
        static void Main()
        {
            var inputNum = int.Parse(Console.ReadLine());
            var bookDictionary = new Dictionary<string, DateTime>();

            for (int i = 0; i < inputNum; i++)
            {
                var currentBook = Console.ReadLine()
                    .Split(' ');

                var bookName = currentBook[0];
                var date = DateTime.ParseExact(currentBook[3],"dd.MM.yyyy",null);

                bookDictionary[bookName] = date;
            }

            var compareDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            foreach (var book in bookDictionary
                .OrderBy(k => k.Value)
                .ThenBy(n => n.Key))
            {
                if (book.Value>compareDate)
                {
                    Console.WriteLine($"{book.Key} -> {book.Value}");
                }
            }
        }
    }
}
