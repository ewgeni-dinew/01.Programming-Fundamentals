using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_BPM_Counter
{
    class Program
    {
        static void Main()
        {
            var BPM = int.Parse(Console.ReadLine());
            var numOfBeats = double.Parse(Console.ReadLine());
            var secondsTotal = Math.Floor(numOfBeats / BPM * 60);
            
            var minutes = Math.Floor(secondsTotal / 60);
            var seconds = (secondsTotal / 60 - minutes)*60;

            Console.Write($"{Math.Round(numOfBeats/4,1)} bars - ");
            Console.Write($"{minutes}m {seconds}s");
        }
    }
}
