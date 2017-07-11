using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Poke_Mo
{
    class Program
    {
        static void Main()
        {
            var pokemonPower = ulong.Parse(Console.ReadLine());
            var distance = ulong.Parse(Console.ReadLine());
            var exhaustionFactor = ulong.Parse(Console.ReadLine());

            ulong count = 0;
            ulong originalValue = pokemonPower;

            while (pokemonPower>=distance)
            {
                pokemonPower -= distance;
                count++;
                if (pokemonPower==originalValue*0.5)
                {
                    if (exhaustionFactor==0)
                    {
                        continue;
                    }
                    else
                    {
                        pokemonPower /= (ulong)exhaustionFactor;
                    }               
                }
            }
            Console.WriteLine(pokemonPower);
            Console.WriteLine(count);
        }
    }
}
