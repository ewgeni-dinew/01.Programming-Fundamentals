using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Phonebook
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program that receives info from the console about people and their phone numbers.
            //On each line you will receive some of the following commands:
            //*A {name}{phone} – adds entry to the phonebook.
            //In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.
            //*S {name} – searches for a contact by given name and prints it in format "{name} -> {number}".
            //In case the contact isn't found, print "Contact {name} does not exist.".
            //END – stop receiving more commands.

            var inputValues = Console.ReadLine()
                .Split(' ')
                .ToList();

            var phonebook = new SortedDictionary<string,string>();

            while (inputValues[0]!="END")
            {
                if (inputValues[0]=="A")
                {
                    phonebook[inputValues[1]] = inputValues[2];
                }
                else if (inputValues[0]=="S")
                {
                    
                    if (!phonebook.ContainsKey(inputValues[1]))
                    {
                        Console.WriteLine($"Contact {inputValues[1]} does not exist.");
                    }
                    else 
                    {
                        Console.WriteLine($"{inputValues[1]} -> {phonebook[inputValues[1]]}");
                    }
                }
                else if (inputValues[0] == "ListAll")
                {
                    foreach (var personalData in phonebook)
                    {
                        Console.WriteLine($"{personalData.Key} -> {personalData.Value}");
                    }
                    
                }
                inputValues.Clear();
                inputValues = Console.ReadLine().Split().ToList();
            }
        }
    }
}
