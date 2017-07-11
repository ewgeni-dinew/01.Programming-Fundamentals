using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_A_Minors_Task
{
    class Program
    {
        static void Main()
        {
            //Task->You are given a sequence of strings, each on a new line. 
            //Every odd line on the console is representing a resource, and every even – quantity.
            //Your task is to collect the resources and print them each on a new line. 

            var resources = new Dictionary<string, decimal>();
            var inputValues = Console.ReadLine();

            while (inputValues != "stop")
            {
                var quantity = decimal.Parse(Console.ReadLine());
                if (!resources.ContainsKey(inputValues))
                {
                    resources[inputValues] = 0;
                    
                }
                    resources[inputValues] += quantity;


                inputValues = Console.ReadLine();
                    
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
