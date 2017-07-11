using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Logs_Aggreg
{
    class Program
    {
        static void Main()
        {
            //Task->You are given a sequence of access logs in format <IP> <user> <duration>.
            //Write a program to aggregate the logs data and print for each user the total duration of his sessions
            //and a list of unique IP addresses in format: <user> <duration> [<IP,IP,...IP>].
            //Order the users alphabetically.Order the IPs alphabetically.

            var inputAmmount = int.Parse(Console.ReadLine());

            var userLogsIPs = new SortedDictionary<string,SortedDictionary<string,int>>();
           
            for (int i = 0; i < inputAmmount; i++)
            {
                var currentData = Console.ReadLine()
                    .Split(' ');

                var IP = currentData[0];
                var name = currentData[1];
                var duration = int.Parse(currentData[2]);

                if (!userLogsIPs.ContainsKey(name))
                {
                    userLogsIPs[name] = new SortedDictionary<string, int>(); 
                }

                if (!userLogsIPs[name].ContainsKey(IP))
                {
                    userLogsIPs[name][IP] = 0;
                }
                userLogsIPs[name][IP] += duration;
            }
            foreach (var user in userLogsIPs)
            {
                var value = user.Value.Sum(a => a.Value);
                Console.WriteLine($"{user.Key}: {value} [{string.Join(", ",user.Value.Keys.ToArray())}]");
            }
        }
    }
}
