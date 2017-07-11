using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Endurance_Rally
{
    class Program
    {
        static void Main()
        {
            //Task->You are given the names of the participants, the track layout and the checkpoint indexes. 
            //The starting fuel of each participant is equal to the ASCII code of the first character of his name.
            //Track layout consists of zones represented by numbers, given on a single line separated by a single space.
            //Every number represents the fuel given or the fuel taken by the current zone of the track:
            //1)If the current zone is a checkpoint, the value of the zone is added to the driver's fuel. 
            //2)If the current zone is not a checkpoint, the value of the zone is subtracted from the driver's fuel.


            var inputNames = Console.ReadLine()
                .Split(' ');

            var trackZones = Console.ReadLine()
                   .Split(' ')
                   .Select(double.Parse)
                   .ToArray();

            var trackCheckpoints = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToArray();

            foreach (var contestant in inputNames)
            {
                double startingFuel = contestant.First();
                for (int i = 0; i < trackZones.Length; i++)
                {
                    var currentZoneFuel = trackZones[i];

                    if (trackCheckpoints.Contains(i))
                    {
                        startingFuel += currentZoneFuel;
                    }
                    else
                    {
                        startingFuel -= currentZoneFuel;
                    }
                    if (startingFuel <= 0)
                    {
                        Console.WriteLine($"{contestant} - reached {i}");
                        break;
                    }
                }
                if (startingFuel > 0)
                {
                    Console.WriteLine($"{contestant} - fuel left {startingFuel:f2}");
                }
            }

            //for (int i = 0; i < inputNames.Length; i++)
            //{
            //    var changedArray = inputNames[i].ToCharArray();
            //    var startingFuel = (int)changedArray[0];

            //    double result = 0.0;
            //    double extraFuel = 0.0;
            //    double neededFuel = 0.0;

            //    for (int j = 0; j < trackZones.Length; j++)
            //    {
            //        for (int l = 0; l < trackCheckpoints.Length; l++)
            //        {
            //            if (j == trackCheckpoints[l])
            //            {
            //                extraFuel += trackZones[j];
            //            }
            //        }
            //        neededFuel += trackZones[j];
            //    }

            //    result = startingFuel - neededFuel + 2 * extraFuel;

            //    if (result > 0)
            //    {
            //        Console.WriteLine($"{inputNames[i]} - fuel left {result:f2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputNames[i]} - reached 2");
            //    }
            //}

        }
    }
}
