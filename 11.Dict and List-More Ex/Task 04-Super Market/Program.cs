using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SupermarketDatabase
{
    class SupermarketDatabase
    {
        static void Main()
        {
            //Task->Write a program, which keeps information about products and their prices. Each product has a name, a price and its quantity.
            //If the product doesn’t exist in the database yet, add it with its starting quantity.
            //If you receive a product, which already exists in the database, increase its quantity by the input quantity
            //and if its price is different, replace the price as well.
            //Until you receive the command “stocked”,keep adding items to the database.
            //When you do receive the command “stocked”, print the items with their names, prices, quantities and total price of all the products with that name.

            var inputLine = Console.ReadLine();

            var marketDataBase = new Dictionary<string, List<double>>();

            while (inputLine != "stocked")
            {
                var inputParameters = inputLine.Split(' ').ToArray();
                var currentProdName = inputParameters[0];
                var currentProdPrice = double.Parse(inputParameters[1]);
                var currentProdQuantity = double.Parse(inputParameters[2]);
                

                if (!marketDataBase.ContainsKey(currentProdName))
                {
                    marketDataBase[currentProdName] = new List<double>();
                    marketDataBase[currentProdName].Add(0);
                    marketDataBase[currentProdName].Add(0);
                }
                marketDataBase[currentProdName][0] = currentProdPrice;
                marketDataBase[currentProdName][1] += currentProdQuantity;

                inputLine = Console.ReadLine();
            }

            foreach (var product in marketDataBase) // Print information about each product
            {
                Console.WriteLine($"{product.Key}: ${product.Value[0]:F2} * {product.Value[1]} = ${product.Value[0] * product.Value[1]:F2}");
            }

            Console.WriteLine(new string('-', 30));  // Print 30 dashes

            double grandTotal = 0;
            foreach (var product in marketDataBase)
            {
                double currentTotal = product.Value[0] * product.Value[1];
                grandTotal += currentTotal;
            }

            Console.WriteLine($"Grand Total: ${grandTotal:f2}");  // Print the grand total
        }
    }
}