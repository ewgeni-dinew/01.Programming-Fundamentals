using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_SoftUni_Karaoke
{
    class Program
    {
        static void Main()
        {
            //Task->On the first line, you will receive a list with all participants that applied for performance. 
            //On the second line, you will receive the list with all available songs. 
            //On the next lines, until the "dawn" command, you will get the names of people, the song that they are performing on stage and the award they get from the audience.

            var participantNames = Console.ReadLine()

                .Split(new[] { ','},StringSplitOptions.RemoveEmptyEntries)
                .Select(p=>p.Trim())
                .ToArray();

            var participantSongs=Console.ReadLine()
                .Split(new[] { ','},StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();

            var inputLine = Console.ReadLine();

            var result = new Dictionary<string, List<string>>();
            
            while (inputLine != "dawn")
            {
                var inputLineArray = inputLine
                    .Split(new[] { ',' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToArray();

                var contestantName = inputLineArray[0];
                var contestantSong = inputLineArray[1];
                var contestantAward = inputLineArray[2];

                if (participantSongs.Contains(contestantSong) && participantNames.Contains(contestantName))
                {
                    if (!result.ContainsKey(contestantName))
                    {
                        result[contestantName]=new List<string>();
                        result[contestantName].Add(contestantAward);
                        
                    }

                    if (!result[contestantName].Contains(contestantAward)) 
                        {
                        result[contestantName].Add(contestantAward);
                        }
                    
                }
                inputLine = Console.ReadLine();
            }

            if (result.Count==0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var participant in result
                    .OrderByDescending(p=>p.Value.Count)
                    .ThenBy(p=>p.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var award in participant.Value.OrderBy(a=>a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
