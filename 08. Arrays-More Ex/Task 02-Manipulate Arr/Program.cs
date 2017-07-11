using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Manipulate_Arr
{
    class Program
    {
        static void Main()
        {
        //Task->You will receive an array of strings and you have to execute some command upon it. You can receive three types of commands:
        //*Reverse – reverse the array
        //*Distinct – delete all non - unique elements from the array
        //*Replace {index} { string} – replace the element at the given index with the string, which will be given to you;

                var inputValues = Console.ReadLine()
                .Split(' ')
                .ToArray();
                
                
            var inputAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputAmount; i++)
            {
                var currentCommand = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                    
                
                if (currentCommand[0]=="Distinct")
                {
                    inputValues=inputValues.Distinct().ToArray();
                }
                else if (currentCommand[0] == "Reverse")
                {
                   inputValues=inputValues.Reverse().ToArray();
                        
                }
                else if (currentCommand[0] =="Replace")
                {
                    var index = int.Parse(currentCommand[1]);
                    var replacement = currentCommand[2];
                    inputValues[index] = replacement;
                }
            }
            Console.WriteLine(string.Join(", ",inputValues));
        }
    }
}
