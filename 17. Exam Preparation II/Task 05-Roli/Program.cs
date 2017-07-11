using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_05_Roli
{
    class Program
    {
        static void Main()
        {
            var events = new Dictionary<int, Event>();
            var line = Console.ReadLine();
            var eventsRegex = new Regex(@"(?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-Z0-9'-]+\s*)*)");

            while (line!= "Time for Code")
            {
                var eventMatch = eventsRegex.Match(line);

                if (!eventMatch.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var id = int.Parse(eventMatch.Groups["id"].Value);
                var eventName = eventMatch.Groups["eventName"].Value;
                var participantsLine = eventMatch.Groups["participants"].Value;

                var participants = new List<string>();
                if (participantsLine.Length>0)
                {
                   participants = participantsLine
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }

                if (!events.ContainsKey(id))
                {
                    var @event = new Event
                    {
                        Name = eventName,
                        Participants = participants
                    };
                    events[id] = @event;
                }

                if (events[id].Name==eventName)
                {
                    events[id].Participants.AddRange(participants);
                }

                line = Console.ReadLine();
            }

            foreach (var @event in events)
            {
                @event.Value.Participants =
                @event.Value.Participants.Distinct().OrderBy(a=>a).ToList(); 
            }

            var sortedEvents = events.OrderByDescending(p => p.Value.Participants.Count)
                .ThenBy(e=>e.Value.Name)
                .Select(a=>a.Value)
                .ToArray();

            foreach (var sortedEvent in sortedEvents)
            {
                Console.WriteLine($"{sortedEvent.Name} - {sortedEvent.Participants.Count}");
                foreach (var item in sortedEvent.Participants)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
    class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }

    }
}
