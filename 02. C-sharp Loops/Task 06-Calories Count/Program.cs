using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Calories_Count
{
    class Program
    {
        static void Main()
        {
            var inputAmount = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < inputAmount; i++)
            {
                var currentIngredient = Console.ReadLine().ToLower();
                if (currentIngredient=="cheese")
                {
                    calories += 500;
                }
                else if (currentIngredient=="tomato sauce")
                {
                    calories += 150;
                }
               else if (currentIngredient == "salami")
                {
                    calories += 600;
                }
                else if (currentIngredient == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");

        }
    }
}
