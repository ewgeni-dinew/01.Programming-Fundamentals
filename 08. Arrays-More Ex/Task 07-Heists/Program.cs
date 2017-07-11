using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Heists
{
    class Program
    {
        static void Main()
        {
            var inputPrice = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double jewelsPrice =inputPrice[0];
            double goldPrice = inputPrice[1];
            double earnings = 0;
            double expenses = 0;

            var line = Console.ReadLine();

            while (line!="Jail Time")
            {
                var currentLine=line.Split(' ').ToArray();
                var currentExpense = double.Parse(currentLine[1]);

                var currentHeist = currentLine[0].ToCharArray();

                for (int i = 0; i < currentHeist.Length; i++)
                {
                    if (currentHeist[i]=='%')
                    {
                        earnings += jewelsPrice;
                    }
                    else if (currentHeist[i]=='$')
                    {
                        earnings += goldPrice;
                    }
                }

                expenses += currentExpense;

                line = Console.ReadLine();
            }
            if (earnings>=expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earnings-expenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expenses-earnings}.");
            }
        }
    }
}
