using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Dessert
{
    class Program
    {
        static void Main()
        {
            var amountCash = double.Parse(Console.ReadLine());
            var numOfGuests = long.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berriesPrice = double.Parse(Console.ReadLine());

            var numOfCakes = Math.Ceiling(numOfGuests / 6.0);
            var cakeIngredMoney = numOfCakes * (2 * bananaPrice + 4* eggPrice + berriesPrice / 5);
            if (amountCash>=cakeIngredMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {cakeIngredMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {cakeIngredMoney-amountCash:f2}lv more.");
            }
        }
    }
}
