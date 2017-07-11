using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_03_Reamls
{
    class Program
    {
        static void Main()
        {
            var inputCharacters = Console.ReadLine()
                .Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = new SortedDictionary<string, Dictionary<long,decimal>>();

            foreach (var charecter in inputCharacters)
            {
                long charHealth = charecter
                    .Where(s => s < '*' || s > '9')
                    .Select(s=>(int)s)
                    .Sum();

                var listOfNums = new List<decimal>();

                var matches = Regex.Matches(charecter, @"-?\d+(?:\.\d+)?");

                foreach (Match match in matches)
                {
                    var stringNum = match.ToString().Replace('.',',');
                    listOfNums.Add(decimal.Parse(stringNum));
                }

                decimal charDamage = listOfNums.Sum();

                foreach (var symbol in charecter)
                {
                    if (symbol=='*')
                    {
                        charDamage *= 2;
                    }
                    else if (symbol=='/')
                    {
                        charDamage /= 2;
                    }
                }

                result[charecter] = new Dictionary<long, decimal>();
                result[charecter][charHealth] = 0;
                result[charecter][charHealth] = charDamage;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {string.Join("",item.Value.Keys)} health, {decimal.Parse(string.Join("", item.Value.Values)):f2} damage");
            }
        }
    }
}
