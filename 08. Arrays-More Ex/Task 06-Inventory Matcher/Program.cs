using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Inventory_Matcher
{
    class Program
    {
        static void Main()
        {
            //Task->You will be given three arrays on different lines. The first one will contain strings, 
            //which will represent the name of products.Second one will contain longs and will represent the quantities of the products.
            //The third one will contain double and represents the price of the product.
            //After which, you will be given names of products on new lines, until you receive the command “done”.
            //For each given product name print:{name of the product} costs: { price}; Available quantity: { quantity}

            var inputFoodType = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var inputFoodAmmount= Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            var inputFoodPrice= Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToArray();

            var searchFood = Console.ReadLine();

            while (searchFood!="done")
            {
                for (int i = 0; i < inputFoodType.Length; i++)
                {
                    if (inputFoodType[i]==searchFood)
                    {
                        Console.WriteLine($"{inputFoodType[i]} costs: {inputFoodPrice[i]}; Available quantity: {inputFoodAmmount[i]}");
                    }
                }
                searchFood = Console.ReadLine();
            }

        }
    }
}
