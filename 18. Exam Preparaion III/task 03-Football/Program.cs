using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task_03_Football
{
    class Program
    {
        static void Main()
        {
            var splitKey = Regex.Escape(Console.ReadLine());
            var line = Console.ReadLine();

            var leagueStandings = new Dictionary<string, int>();
            var goalScores = new Dictionary<string, int>();
            
            while (line!="final")
            {
                var currentMatch = Regex.Match(line, $@"^.*(?:{splitKey})(?<teamOne>[a-zA-Z]*)(?:{splitKey}).* .*(?:{splitKey})(?<teamTwo>[a-zA-Z]*)(?:{splitKey}).* (?<teamOneScore>\d+):(?<teamTwoScore>\d+).*$");

                    var homeTeam = new string(currentMatch.Groups["teamOne"].Value.ToUpper().Reverse().ToArray());
                    var awayTeam = new string(currentMatch.Groups["teamTwo"].Value.ToUpper().Reverse().ToArray());
                    var homeTeamGoals = int.Parse(currentMatch.Groups["teamOneScore"].Value);
                    var awayTeamGoals = int.Parse(currentMatch.Groups["teamTwoScore"].Value);

                if (!leagueStandings.ContainsKey(homeTeam))
                {
                    leagueStandings[homeTeam] = 0;
                }

                if (!leagueStandings.ContainsKey(awayTeam))
                {
                    leagueStandings[awayTeam] = 0;
                }

                if (homeTeamGoals>awayTeamGoals)
                {
                    leagueStandings[homeTeam] += 3;
                }
                else if (homeTeamGoals==awayTeamGoals)
                {
                    leagueStandings[homeTeam] += 1;
                    leagueStandings[awayTeam] += 1;
                }
                else
                {
                    leagueStandings[awayTeam] += 3;
                }

                if (!goalScores.ContainsKey(homeTeam))
                {
                    goalScores[homeTeam] = 0;
                }
                if (!goalScores.ContainsKey(awayTeam))
                {
                    goalScores[awayTeam] = 0;
                }
                goalScores[homeTeam] += homeTeamGoals;
                goalScores[awayTeam] += awayTeamGoals;

                line = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            var count = 1;
            foreach (var team in leagueStandings
                .OrderByDescending(t=>t.Value)
                .ThenBy(a=>a.Key))
            {
                Console.WriteLine($"{count++}. {team.Key} {team.Value}");
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in goalScores
                .OrderByDescending(g=>g.Value)
                .ThenBy(t=>t.Key)
                .Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
    }
}
