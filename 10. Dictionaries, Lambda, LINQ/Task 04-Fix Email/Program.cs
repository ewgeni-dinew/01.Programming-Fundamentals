using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04_Fix_Email
{
    class Program
    {
        static void Main()
        {
        //Task->You are given a sequence of strings, each on a new line, until you receive the “stop” command. 
        //The first string is the name of a person. On the second line you will receive their email. 
        //Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive).
        

            var dataList = new Dictionary<string, string>();
            var inputValue = Console.ReadLine();

            while (inputValue!="stop")
            {
                var email = Console.ReadLine();
                dataList[inputValue] = email;
                inputValue = Console.ReadLine();
                
            }
            var fixedEmails = dataList
                    .Where(a => !a.Value.ToLower().EndsWith("us") && !a.Value.ToLower().EndsWith("us"))
                    .ToDictionary(p => p.Key, p => p.Value);

            foreach (var item in fixedEmails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
