using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Change_List
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program, which reads a list of integers from the console and receives commands, which manipulate the list.
            //Your program may receive the following commands:
            //*Delete {element} – delete all elements in the array, which are equal to the given element
            //*Insert {element} {position} – insert element and the given position
            //When you receive the command "Odd" or "Even" stop the program and print all odd/even numbers.

            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var line = Console.ReadLine();

            while (line!="Odd"&&line!="Even")
            {
                var currentCommand = line
                    .Split(' ')
                    .ToArray();
                if (currentCommand[0]=="Insert")
                {
                    inputNums.Insert(int.Parse(currentCommand[2]),int.Parse(currentCommand[1]));
                }
                else if (currentCommand[0]=="Delete")
                {
                    inputNums.RemoveAll(num=>num==int.Parse(currentCommand[1]));
                }
                line = Console.ReadLine();
            }
            if (line=="Odd")
            {
                foreach (var number in inputNums)
                {
                    if (number%2!=0)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            else
            {
                foreach (var number in inputNums)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
        }
    }
}
