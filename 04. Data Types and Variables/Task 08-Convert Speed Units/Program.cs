using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08_Convert_Speed_Units
{
    class Program
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float metersPerSecond = (float)distance / (hours*3600.0f+minutes*60.0f+seconds);
            float kilometersPerHour = (float)(distance / 1000.0) /(float)(hours + minutes/60.0 + seconds/3600.0);
            float milesPerHour=(float)(distance/1609.0)/ (float)(hours + minutes / 60.0 + seconds / 3600.0);
            Console.WriteLine("{0}",metersPerSecond);
            Console.WriteLine("{0}",kilometersPerHour);
            Console.WriteLine("{0}",milesPerHour);




        }
    }
}
