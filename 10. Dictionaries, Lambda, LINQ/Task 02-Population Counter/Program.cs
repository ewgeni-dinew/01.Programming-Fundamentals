using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Population_Counter
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var countryDict = new Dictionary<Dictionary<string, int>, Dictionary<string, int>>();
            var keyDict = new Dictionary<string, int>();
            var valueDict = new Dictionary<string, int>();

            while (line!="report")
            {
                var currentStatistics = line
                    .Split('|')
                    .ToArray();

                var cityName = currentStatistics[0];
                var countryName = currentStatistics[1];
                int cityPopulation = int.Parse(currentStatistics[2]);

                if (!keyDict.ContainsKey(countryName))
                {
                    keyDict[countryName] = 0;
                }
                    keyDict[countryName] += cityPopulation;

                if (!valueDict.ContainsKey(cityName))
                {
                    valueDict[cityName] = cityPopulation;
                }

                countryDict[keyDict] = valueDict;
                line = Console.ReadLine();
            }
            foreach (var statistics in countryDict)
            {
                foreach (var country in keyDict.OrderByDescending(p=>p))
                {
                    Console.WriteLine($"{country.Key}=>{country.Value}");
                }
            }
        }
    }
}
