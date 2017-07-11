using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace _08MentorGroup
{
    class UsersAttended
    {
        public string Username { get; set; }
        public List<DateTime> Dates { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<UsersAttended> genuineUsers = ReadDates();
            Dictionary<string, List<string>> userComments = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of comments")
                    break;
                string user = input.Split('-')[0];
                string comment = input.Split('-')[1];
                bool attended = false;
                for (int i = 0; i < genuineUsers.Count; i++)
                {
                    if (genuineUsers[i].Username == user)
                    {
                        attended = true;
                        break;
                    }
                }

                if (attended)
                {
                    if (!userComments.ContainsKey(user))
                        userComments.Add(user, new List<string>());
                    userComments[user].Add(comment);
                }
            }
            //ordering
            genuineUsers = genuineUsers.OrderBy(p => p.Username).ToList();
            for (int i = 0; i < genuineUsers.Count; i++)
            {
                genuineUsers[i].Dates = genuineUsers[i].Dates.OrderBy(p => p).ToList();
            }
            //writing
            foreach (var user in genuineUsers)
            {
                Console.WriteLine(user.Username);
                Console.WriteLine("Comments:");
                if (userComments.ContainsKey(user.Username))
                {
                    foreach (var comment in userComments[user.Username])
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in user.Dates)
                {
                    Console.WriteLine("-- {0}", date.ToString("dd/MM/yyyy"));
                }
            }
        }

        static List<UsersAttended> ReadDates()
        {
            List<UsersAttended> dates = new List<UsersAttended>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of dates")
                    break;
                string[] userDate = input.Split();

                if (userDate.Length > 1)
                {
                    string username = userDate[0];
                    string datesOnly = userDate[1];
                    DateTime[] sepDates = datesOnly.Split(',').Select(p => DateTime.ParseExact(p, "dd/MM/yyyy", CultureInfo.InstalledUICulture)).ToArray();
                    UsersAttended currentUser = new UsersAttended();
                    currentUser.Username = username;
                    currentUser.Dates = new List<DateTime>();
                    currentUser.Dates.AddRange(sepDates);
                    bool existingUsername = false;
                    for (int i = 0; i < dates.Count; i++)
                    {
                        if (dates[i].Username == currentUser.Username)
                        {
                            existingUsername = true;
                            dates[i].Dates.AddRange(currentUser.Dates);
                            break;
                        }
                    }
                    if (!existingUsername)
                    {
                        dates.Add(currentUser);
                    }
                }
                else
                {
                    string username = userDate[0];
                    UsersAttended currentUser = new UsersAttended();
                    currentUser.Username = username;
                    currentUser.Dates = new List<DateTime>();
                    dates.Add(currentUser);

                }

            }
            return dates;
        }
    }
}