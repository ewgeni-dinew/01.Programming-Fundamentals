using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Immune_System
{
    class Program
    {
        static void Main()
        {
            //Task->An organism can encounter different types of viruses. If it has already encountered the virus, it fights it faster.
            //The immune system can calculate the virus’ strength before it fights it.It is the sum of all the virus name’s letters’ ASCII codes, divided by 3.
            //The time it takes to defeat a virus in seconds can also be calculated. It is equal to the virus strength, multiplied by the length of the virus’ name.
            //When you calculate the time to defeat the virus, convert it to minutes and seconds Do not use any leading zeroes for the minutes and seconds.
            //After a virus is defeated, the immune system regains 20 % of its strength. 
            //If the 20 percent exceeds the initial health of the immune system, set it to the initial health instead.
            //If you encounter a virus any subsequent times, do not decrease its time to defeat further. 
            //When you receive the line "end", print the status of the immune system in the format "Final Health: {finalHealth}".

            var initialHealth = int.Parse(Console.ReadLine());
            var currentHealth = initialHealth;
        
            var virusNameList = new List<string>();
           
            var currentLine = Console.ReadLine();

            while (currentLine!="end")
            {
                var virusStrength = currentLine.Sum(w=>w)/3;
                var virusDefeatTime = 0;
                if (!virusNameList.Contains(currentLine))
                {
                    virusNameList.Add(currentLine);
                    virusDefeatTime = virusStrength * currentLine.Length;
                }
                else
                {
                    virusDefeatTime = virusStrength * currentLine.Length/3;
                }

                Console.WriteLine($"Virus {currentLine}: {virusStrength} => {virusDefeatTime} seconds");

                if (currentHealth>virusDefeatTime)
                {
                    var virusDefeatMinutes =Math.Floor((double)virusDefeatTime / 60);
                    var virusDefeatSeconds = virusDefeatTime % 60;
                            
                    Console.WriteLine($"{currentLine} defeated in {virusDefeatMinutes}m {virusDefeatSeconds}s.");
                    currentHealth -= virusDefeatTime;
                    Console.WriteLine($"Remaining health: {currentHealth}");
                   
                }
                else if (currentHealth < virusDefeatTime)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

               
                if (currentHealth*1.2>initialHealth)
                {
                    currentHealth = initialHealth;
                }
                else
                {
                    currentHealth = (int)(currentHealth*1.2);
                }

                currentLine = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {currentHealth}");
        }
    }
}
