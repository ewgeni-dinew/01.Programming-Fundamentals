using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Charity_Marathon
{
    class Program
    {
        static void Main()
        {
            var numOfDays = long.Parse(Console.ReadLine());
            var numOfParticipants = long.Parse(Console.ReadLine());
            var numOfLaps = int.Parse(Console.ReadLine());
            var trackLength = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var donatedMoney = double.Parse(Console.ReadLine());

            var participants = Math.Min(numOfParticipants, (numOfDays * trackCapacity));
            var length = participants * numOfLaps * trackLength / 1000;
            Console.WriteLine($"Money raised: {length*donatedMoney:f2}");
        }
    }
}
