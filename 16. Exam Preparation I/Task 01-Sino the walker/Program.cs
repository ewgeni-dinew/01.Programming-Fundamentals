using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Sino_the_walker
{
    class Program
    {
        static void Main()
        {
            //Task->You will receive the time that Sino leaves SoftUni, the steps taken and time for each step in seconds. 
           // You need to print the exact time that he will arrive at home in the format specified.
            var leaveTime = DateTime.ParseExact(Console.ReadLine(), "H:m:s", null);
            var numberOfSteps = long.Parse(Console.ReadLine());
            var eachStepInSeconds = long.Parse(Console.ReadLine());
            
            var day = 24 * 3600;
            var time = (eachStepInSeconds * numberOfSteps) % day;
            leaveTime = leaveTime.AddSeconds(time);
            var result = leaveTime.ToString("HH:mm:ss");
            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
