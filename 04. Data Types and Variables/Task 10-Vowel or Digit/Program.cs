using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Vowel_or_Digit
{
    class Program
    {
        static void Main()
        {
            char inputSymbol = char.Parse(Console.ReadLine());
            if (inputSymbol == 'e' || inputSymbol == 'a' || inputSymbol == 'u' || inputSymbol == 'i' || inputSymbol == 'o' || inputSymbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (inputSymbol == '*' || inputSymbol == '@' || inputSymbol == '#' || inputSymbol == '$' || inputSymbol == '%' || inputSymbol == '.')
            {
                Console.WriteLine("other");
            }
            else if (inputSymbol >= int.MinValue && inputSymbol <= int.MaxValue)
            {
                Console.WriteLine("digit");
            }

            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
