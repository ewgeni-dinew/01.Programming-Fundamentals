using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_04_Winning_Ticket
{
    class Program
    {
        static void Main()
        {
            //Task->You are given a collection of tickets separated by commas and spaces.
            //You need to check every one of them if it has a winning combination of symbols.
            //A valid ticket should have exactly 20 characters.The winning symbols are '@', '#', '$' and '^'.
            //A ticket is a winner if the same winning symbol should uninterruptedly repeat for at least 6 times 
            //in both the tickets left half and the tickets right half.
        
            var inputValue = Console.ReadLine()
                .Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(t=>t.Trim())
                .ToArray();

            foreach (var ticket in inputValue)
            {
                if (ticket.Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var leftSide = new string(ticket.Take(10).ToArray());
                    var rightSide = new string(ticket.Skip(10).ToArray());
                    
                    if (Regex.Match(leftSide, @"[@]{10}").Success && Regex.Match(rightSide, @"[@]{10}").Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10@ Jackpot!");
                    }
                    else if (Regex.Match(leftSide, @"[$]{10}").Success && Regex.Match(rightSide, @"[$]{10}").Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10$ Jackpot!");
                    }
                    else if (Regex.Match(leftSide, @"[\^]{10}").Success && Regex.Match(rightSide, @"[\^]{10}").Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10^ Jackpot!");
                    }
                    else if (Regex.Match(leftSide, @"[#]{10}").Success && Regex.Match(rightSide, @"[#]{10}").Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10# Jackpot!");
                    }
                    else if (Regex.Match(leftSide, @"[@]{6,9}").Success&& Regex.Match(rightSide, @"[@]{6,9}").Success)
                    {
                        var leftCount = 0;
                        var rightCount = 0;
                        foreach (var item in leftSide)
                        {
                            if (item=='@')
                            {
                                leftCount++;
                            }
                        }
                        foreach (var item in rightSide)
                        {
                            if (item == '@')
                            {
                                rightCount++;
                            }
                        }

                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftCount,rightCount)}@");
                    }
                    else if (Regex.Match(leftSide, @"[#]{6,9}").Success && Regex.Match(rightSide, @"[#]{6,9}").Success)
                    {
                        var leftCount = 0;
                        var rightCount = 0;
                        foreach (var item in leftSide)
                        {
                            if (item == '#')
                            {
                                leftCount++;
                            }
                        }
                        foreach (var item in rightSide)
                        {
                            if (item == '#')
                            {
                                rightCount++;
                            }
                        }

                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftCount, rightCount)}#");
                    }
                    else if (Regex.Match(leftSide, @"[\^]{6,9}").Success && Regex.Match(rightSide, @"[\^]{6,9}").Success)
                    {
                        var leftCount = 0;
                        var rightCount = 0;
                        foreach (var item in leftSide)
                        {
                            if (item == '^')
                            {
                                leftCount++;
                            }
                        }
                        foreach (var item in rightSide)
                        {
                            if (item == '^')
                            {
                                rightCount++;
                            }
                        }

                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftCount, rightCount)}^");
                    }
                    else if (Regex.Match(leftSide, @"[$]{6,9}").Success && Regex.Match(rightSide, @"[$]{6,9}").Success)
                    {
                        var leftCount = 0;
                        var rightCount = 0;
                        foreach (var item in leftSide)
                        {
                            if (item == '$')
                            {
                                leftCount++;
                            }
                        }
                        foreach (var item in rightSide)
                        {
                            if (item == '$')
                            {
                                rightCount++;
                            }
                        }

                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftCount, rightCount)}$");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
            
        }
    }
}
