using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Beverage_Labels
{
    class Program
    {
        static void Main()
        {
            var inputName = Console.ReadLine();
            var inputVolume = int.Parse(Console.ReadLine());
            var inputEnergyContent= int.Parse(Console.ReadLine());
            var inputSugarContent= int.Parse(Console.ReadLine());

            var kcal = inputVolume / 100.0 * inputEnergyContent;
            var sugars = inputVolume / 100.0 * inputSugarContent;

            Console.WriteLine($"{inputVolume}ml {inputName}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
