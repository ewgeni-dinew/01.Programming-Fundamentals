using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Restaurant_Discount
{
    class Program
    {
        static void Main()
        {
            var inputAmount = int.Parse(Console.ReadLine());
            var packageType = Console.ReadLine();
            double price = 0;
            double individualPrice = 0;

            if (inputAmount<=50)
            {
                price = 2500;
                if (packageType=="Normal")
                {
                    price += 500;
                    individualPrice = price * 0.95 / inputAmount;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");
                    
                }
                else if (packageType=="Gold")
                {
                    price += 750;
                    individualPrice = price * 0.90 / inputAmount;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");

                }
                else if (packageType=="Platinum")
                {
                    price += 1000;
                    individualPrice = price * 0.85 / inputAmount;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");
                }
            }
            else if (inputAmount<=100)
            {
                price = 5000;
                if (packageType == "Normal")
                {
                    price += 500;
                    individualPrice = price * 0.95 / inputAmount;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");

                }
                else if (packageType == "Gold")
                {
                    price += 750;
                    individualPrice = price * 0.90 / inputAmount;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");

                }
                else if (packageType == "Platinum")
                {
                    price += 1000;
                    individualPrice = price * 0.85 / inputAmount;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");
                }
            }
            else if (inputAmount<=120)
            {
                price = 7500;
                if (packageType == "Normal")
                {
                    price += 500;
                    individualPrice = price * 0.95 / inputAmount;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");

                }
                else if (packageType == "Gold")
                {
                    price += 750;
                    individualPrice = price * 0.90 / inputAmount;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");

                }
                else if (packageType == "Platinum")
                {
                    price += 1000;
                    individualPrice = price * 0.85 / inputAmount;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {individualPrice:f2}$");
                }
            }
            else
            {
                    Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
