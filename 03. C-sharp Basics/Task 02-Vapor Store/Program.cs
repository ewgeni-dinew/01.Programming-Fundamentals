using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Vapor_Store
{
    class Program
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var inputValue = Console.ReadLine();
            double moneySpent = 0;
            double currentMoney = 0;

            while (inputValue!="Game Time")
            {
                
                    if (inputValue == "OutFall 4")
                    {
                    currentMoney = 39.99;
                    if (budget >= currentMoney)
                    {
                        moneySpent += currentMoney;
                        budget -= currentMoney;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else if (budget == currentMoney)
                    {
                        budget -= currentMoney;
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (budget < currentMoney)
                    {
                        Console.WriteLine("Too Expensive");
                    }
   
                    }
                    else if (inputValue == "CS: OG")
                    {
                        currentMoney = 15.99;
                    if (budget >= currentMoney)
                    {
                        moneySpent += currentMoney;
                        budget -= currentMoney;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else if (budget == currentMoney)
                    {
                        budget -= currentMoney;
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (budget < currentMoney)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (inputValue == "Zplinter Zell")
                    {

                    currentMoney = 19.99;
                    if (budget >= currentMoney)
                    {
                        moneySpent += currentMoney;
                        budget -= currentMoney;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else if (budget == currentMoney)
                    {
                        budget -= currentMoney;
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (budget < currentMoney)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (inputValue == "Honored 2")
                    {
                    currentMoney = 59.99;
                    if (budget >= currentMoney)
                    {
                        moneySpent += currentMoney;
                        budget -= currentMoney;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else if (budget == currentMoney)
                    {
                        budget -= currentMoney;
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (budget < currentMoney)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                    else if (inputValue == "RoverWatch")
                    {
                    currentMoney = 29.99;
                    if (budget >= currentMoney)
                    {
                        moneySpent += currentMoney;
                        budget -= currentMoney;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else if (budget == currentMoney)
                    {
                        budget -= currentMoney;
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (budget < currentMoney)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                    else if (inputValue == "RoverWatch Origins Edition")
                    {
                    currentMoney = 39.99;
                    if (budget >= currentMoney)
                    {
                        moneySpent += currentMoney;
                        budget -= currentMoney;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else if (budget == currentMoney)
                    {
                        budget -= currentMoney;
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else if (budget < currentMoney)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                    else 
                    {
                         Console.WriteLine("Not Found");
                    }
                    inputValue = Console.ReadLine();
                }
            if (budget!=0)
            {
                Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${budget:f2}");
            }
            }
        }
    }

