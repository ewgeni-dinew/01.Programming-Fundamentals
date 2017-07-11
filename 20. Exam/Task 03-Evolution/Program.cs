using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Evolution
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var result = new Dictionary<string, List<Pokemon>>();

            while (line!= "wubbalubbadubdub")
            {
                var currentLine = line
                    .Split(new[] { ' ','-','>'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var pokemonName = currentLine[0];

                if (currentLine.Count==1)
                {
                    if (result.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var item in result[pokemonName])
                        {
                            Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
                        }
                    }
                }
                else
                { 
                    var type = currentLine[1];
                    var index = int.Parse(currentLine[2]);
                    var currentPokemon = new Pokemon
                    {
                        EvolutionType = type,
                        EvolutionIndex = index
                    };

                    if (!result.ContainsKey(pokemonName))
                    {
                        
                        result[pokemonName] = new List<Pokemon>();
                        
                    }
                    result[pokemonName].Add(currentPokemon);
                }
                line = Console.ReadLine();
            }

            foreach (var pokemon in result)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var item in pokemon.Value.OrderByDescending(a=>a.EvolutionIndex))
                {
                    Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
                }
            }
        }
       public class Pokemon
        {
            public string EvolutionType { get; set; }
            public int EvolutionIndex { get; set; }
        }
    }
}
