using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Centuries_To_Nanoseconds
{
    class Program
    {
        static void Main()
        {
            short centuries = short.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = 365.24 * years;
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            double miliSeconds = seconds * 1000;
            double microSeconds = miliSeconds;
            double nanoseconds = miliSeconds;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} milliseconds = {microSeconds}000 microseconds = {nanoseconds}000000 nanoseconds");


        }
    }
}
