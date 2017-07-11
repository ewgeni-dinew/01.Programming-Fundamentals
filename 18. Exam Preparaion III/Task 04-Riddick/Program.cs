using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_04_Riddick
{
    class Program
    {
        static void Main()
        {
            var randomChars = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            var resultDict = new Dictionary<string, List<char>>();

            while (randomChars!="Over!")
            {
                var matched = Regex.Match(randomChars, @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<right>[^a-zA-Z]*)$");
                var result = new List<char>();

                if (matched.Success)
                {
                    var leftNums = new string(matched.Groups["leftPart"].Value.ToArray());
                    var message = new string(matched.Groups["message"].Value.ToArray());
                    var rightNums = new string(matched.Groups["right"].Value.ToArray());
                    if (number!=message.Length)
                    {
                        randomChars = Console.ReadLine();
                        number = int.Parse(Console.ReadLine());
                        continue;
                    }

                    foreach (var symbol in leftNums.Where(s=>s>='0'&&s<='9'))
                    {
                        var numExists = int.Parse(symbol.ToString());
                        if (numExists >= 0 && numExists <= message.Length - 1)
                        {
                            result.Add(message.ElementAt(numExists));
                        }
                        else
                        {
                            result.Add(' ');
                        }
                    }
                    foreach (var symbol in rightNums.Where(s => s >= '0' && s <= '9'))
                    {
                        var numExists = int.Parse(symbol.ToString());
                        if (numExists >= 0 && numExists <= message.Length - 1)
                        {
                            result.Add(message.ElementAt(numExists));
                        }
                        else
                        {
                            result.Add(' ');
                        }
                    }
                    
                    resultDict[message] = new List<char>();
                    resultDict[message] = result;

                }
                randomChars = Console.ReadLine();
                if (randomChars== "Over!")
                {
                    continue;
                }
                else
                {
                    number = int.Parse(Console.ReadLine());
                }
                
            }
            foreach (var item in resultDict)
            {
                Console.WriteLine($"{item.Key} == {string.Join("",item.Value)}");
            }
        }
    }
}
