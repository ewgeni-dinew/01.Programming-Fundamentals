using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Command
{
    class Program
    {
        static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Where()
                .Select(int.Parse)
                .ToList();

            var line = Console.ReadLine();

            while (line!="end")
            {
                var currentLine = line.
                    Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = currentLine[0];

                if (command=="reverse")
                {
                    //if (double.Parse(currentLine[2])%1!=0|| double.Parse(currentLine[4]) % 1 != 0||)
                    //{

                    //}
                    if (int.Parse(currentLine[2])<0|| int.Parse(currentLine[2])>inputNums.Count-1||
                        int.Parse(currentLine[4])<0|| int.Parse(currentLine[4])>inputNums.Count-1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        var start = int.Parse(currentLine[2]);
                        var count = int.Parse(currentLine[4]);
                        var takeFirst = inputNums.Take(start).ToList();
                        var middle = inputNums.Skip(start).Take(count).Reverse().ToList();
                        var last = inputNums.Skip(start + count).ToList();
                        inputNums.Clear();
                        inputNums.AddRange(takeFirst);
                        inputNums.AddRange(middle);
                        inputNums.AddRange(last);
                    }
                    
                }
                else if (command=="sort")
                {
                    if (int.Parse(currentLine[2]) < 0 || int.Parse(currentLine[2]) > inputNums.Count - 1 ||
                        int.Parse(currentLine[4]) < 0 || int.Parse(currentLine[4]) > inputNums.Count - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        var start = int.Parse(currentLine[2]);
                        var count = int.Parse(currentLine[4]);
                        var takeFirst = inputNums.Take(start).ToList();
                        var middle = inputNums.Take(count).OrderBy(a => a).ToList();
                        var last = inputNums.Skip(count + start).ToList();
                        inputNums.Clear();
                        inputNums.AddRange(takeFirst);
                        inputNums.AddRange(middle);
                        inputNums.AddRange(last);
                    }
                    
                }
                else if (command == "rollLeft")
                {
                    if (int.Parse(currentLine[1]) < 0 || int.Parse(currentLine[1]) > inputNums.Count - 1 )
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(currentLine[1]); i++)
                        {
                            var firstEl = inputNums.First();
                            inputNums.RemoveAt(0);
                            inputNums.Add(firstEl);
                        }
                    }
                    
                }
                else if (command == "rollRight")
                {
                    if (int.Parse(currentLine[1]) < 0 || int.Parse(currentLine[1]) > inputNums.Count - 1)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(currentLine[1]); i++)
                        {
                            var lastEl = inputNums.Last();
                            var part = inputNums.Take(inputNums.Count - 1).ToList();
                            inputNums.Clear();
                            inputNums.Add(lastEl);
                            inputNums.AddRange(part);
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ",inputNums)}]");
        }
    }
}
