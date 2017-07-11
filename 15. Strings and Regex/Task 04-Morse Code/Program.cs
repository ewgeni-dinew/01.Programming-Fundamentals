using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Morse_Code
{
    class Program
    {
        static void Main()
        {
            //Task->You will receive the input in the format:{firstLetterOfTheMessage}|{secondLetterOfTheMessage}|…|{nthLetterOfTheMessage}
            //Each part of the message will consist only of ‘0’ and ‘1’. Each part of the message will transform into a char from the ASCII table
            //The transformation for each part happens in the following way:
            //*Each 0 adds 3 to the total sum.
            //*Each 1 adds 5 to the total sum.
            //*Every time you receive a sequence of equal digits, the sum increases by the count of the equal digits.

            var inputText = Console.ReadLine()
                .Split('|');

            int sum = 0;
            var result = new List<char>();

            for (int i = 0; i < inputText.Length; i++)
            {
                var currentPart = inputText[i].ToCharArray();

                foreach (var symbol in currentPart)
                {
                    if (symbol == '1')
                    {
                        sum += 5;
                    }
                    else
                    {
                        sum += 3;
                    }
                }

                var index = currentPart[0];
                var count = 1;


                for (int j = 1; j < currentPart.Length; j++)
                {
                    if (currentPart[j] == index)
                    {
                        count++;
                        if (j == currentPart.Length - 1 && count > 1)
                        {
                            sum += count;
                        }
                    }
                    else
                    {
                        if (count > 1)
                        {
                            sum += count;
                        }
                        count = 1;
                    }
                    index = currentPart[j];
                }
                result.Add((char)sum);
                sum = 0;
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}