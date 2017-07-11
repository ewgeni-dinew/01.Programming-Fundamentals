using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_04_Weather
{
    class Program
    {
        static void Main()
        {
            var inputText = Console.ReadLine();

            var regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[a-zA-Z]+)\|");
       
            var tempDict = new Dictionary<string, WeatherInfo>();

            while (inputText != "end")
            {
                var matchedWeather = regex.Match(inputText);

                if (!matchedWeather.Success)
                {
                    inputText = Console.ReadLine();
                    continue;
                }
                else
                {
                    var city = matchedWeather.Groups["city"].Value;
                    var temp = double.Parse(matchedWeather.Groups["temp"].Value);
                    var weather = matchedWeather.Groups["weather"].Value;

                    var weatherInfo = new WeatherInfo
                    {
                        AverageTemp = temp,
                        Weather = weather
                    };

                    tempDict[city] = weatherInfo;
                    inputText = Console.ReadLine();
                }
            }
            foreach (var eachCity in tempDict
                .OrderBy(a=>a.Value.AverageTemp)
                .ToDictionary(a=>a.Key, a=>a.Value))
            {
                Console.WriteLine($"{eachCity.Key} => {eachCity.Value.AverageTemp:f2} => {eachCity.Value.Weather}");
            }
        }
    }
    class WeatherInfo
    {
        public double AverageTemp { get; set; }
        public string Weather { get; set; }
    }
}
