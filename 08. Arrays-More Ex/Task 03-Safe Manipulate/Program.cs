using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Safe_Manipulate
{
    class Program
    {
        static void Main()
        {
            //Task->You will receive an array of strings and you have to execute some command upon it. You can receive three types of commands:
            //*Reverse – reverse the array
            //*Distinct – delete all non - unique elements from the array
            //*Replace {index} { string} – replace the element at the given index with the string, which will be given to you;
            //Make the program print “Invalid input!” if we tryto replace an element at a non - existent index or an invalid command is written on the console.
            //Also make the program work until the command “END” is given as an input.




            var inputValues = Console.ReadLine()
            .Split(' ')
            .ToArray();

            var Command = Console.ReadLine();

            while (Command!="END")
            {
                var currentCommand = Command
                    .Split(' ')
                    .ToArray();

                if (currentCommand[0] == "Distinct")
                {
                    inputValues = inputValues.Distinct().ToArray();
                }
                else if (currentCommand[0] == "Reverse")
                {
                    inputValues = inputValues.Reverse().ToArray();
                }
                else if (currentCommand[0] == "Replace")
                {
                    var index = int.Parse(currentCommand[1]);
                    var replacement = currentCommand[2];
                    if (index>=0 &&index<inputValues.Length)
                    {
                        inputValues[index] = replacement;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                Command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", inputValues));
        }
    }
}
