using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Lady_bug
{
    class Program
    {
        static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(a=> a>=0&&a<fieldSize)
                .ToArray();

            var line = Console.ReadLine();

            var ladybugs = new int[fieldSize];

            for (int i = 0; i < ladybugIndexes.Length; i++)
            {
                ladybugs[ladybugIndexes[i]] = 1;
            }

            while (line!="end")
            {
                var currentMove = line.Split(' ').ToArray();

                var ladybugIndex = int.Parse(currentMove[0]);
                var direction = currentMove[1];
                var count = int.Parse(currentMove[2]);

                if (ladybugIndex< 0 || ladybugIndex >= fieldSize)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (ladybugs[ladybugIndex]!=1)
                {
                    line = Console.ReadLine();
                    continue;
                }
          
                MoveLadybug(ladybugs, ladybugIndex, direction, count);
                     
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",ladybugs));
        }

        public static void MoveLadybug(int[] ladybugs, int ladybugIndex, string direction, int count)
        {
            if (direction=="left")
            {
                count = -count;
            }

            var nextIndex = ladybugIndex + count;

            ladybugs[ladybugIndex] = 0;

            var foundItsPlace = false;

            while (foundItsPlace==true)
            {
                if (nextIndex<0||nextIndex>ladybugs.Length-1)
                {
                    foundItsPlace = true;
                    continue;
                }
                if (ladybugs[nextIndex]==1)
                {
                    nextIndex += count;
                    continue;
                }
                ladybugs[nextIndex] = 1;
                foundItsPlace = true;
            }
        }
    }
}
