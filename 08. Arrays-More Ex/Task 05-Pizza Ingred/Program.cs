using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Pizza_Ingred
{
    class Program
    {
        static void Main()
        {
            //Task->On the first line, you will receive an array of strings with the possible ingredients. 
            //On the next line, you will receive an integer, which represents the length of the strings, which we will used in the recipe.
            //Your recipe should not use more than 10 ingredients.
            // If you collect 10 ingredients stop the program and print the  result.

            var inputAllIngredients = Console.ReadLine()
                .Split(' ')
                .ToArray();


            var searchedLength = int.Parse(Console.ReadLine());

            int count = 0;

            var endIngredients = new List<string>();

            for (int i = 0; i < inputAllIngredients.Length; i++)
            {
                var currentIngr = inputAllIngredients[i]
                    .ToCharArray();

                if (currentIngr.Length==searchedLength)
                {
                    if (count >= 10)
                    {
                        break;
                    }
                    else
                    {
                        count++;
                        endIngredients.Add(inputAllIngredients[i]);
                        Console.WriteLine($"Adding {inputAllIngredients[i]}.");
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",endIngredients)}.");
        }
    }
}
