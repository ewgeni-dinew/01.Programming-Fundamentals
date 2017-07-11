using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Arr_Multiplier
{
    class Program
    {
        static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var line = Console.ReadLine();

            while (line!="end")
            {
                var currentLine = line.Split(' ');
                var command = currentLine[0];

                if (command == "exchange")
                {
                    var index = int.Parse(currentLine[1]);
                    if (index < 0 || index > inputNums.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        var takeLastNums = inputNums.Skip(index + 1).ToList();
                        var takeFirstNums = inputNums.Take(index + 1).ToList();
                        inputNums.Clear();
                        inputNums.AddRange(takeLastNums);
                        inputNums.AddRange(takeFirstNums);

                    }
                }
                else if (currentLine.Length == 2)
                {
                    if (currentLine[1] == "even")
                    {
                        if (command == "max")
                        {
                            if (inputNums.Where(n => n % 2 == 0).Count() == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var number = inputNums.Where(n => n % 2 == 0).Max();
                                for (int i = inputNums.Count - 1; i >= 0; i--)
                                {
                                    if (inputNums[i] == number)
                                    {
                                        Console.WriteLine(i);
                                        break;
                                    }
                                }
                            }
                        }
                        else if (command == "min")
                        {
                            if (inputNums.Where(n => n % 2 == 0).Count() == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var number = inputNums.Where(n => n % 2 == 0).Min();
                                for (int i = inputNums.Count - 1; i >= 0; i--)
                                {
                                    if (inputNums[i] == number)
                                    {
                                        Console.WriteLine(i);
                                        break;
                                    }
                                }
                            }

                        }
                    }
                    else if (currentLine[1] == "odd")
                    {
                        if (command == "max")
                        {
                            if (inputNums.Where(n => n % 2 != 0).Count() == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var number = inputNums.Where(n => n % 2 != 0).Max();
                                for (int i = inputNums.Count - 1; i >= 0; i--)
                                {
                                    if (inputNums[i] == number)
                                    {
                                        Console.WriteLine(i);
                                        break;
                                    }
                                }
                            }
                        }
                        else if (command == "min")
                        {
                            if (inputNums.Where(n => n % 2 != 0).Count() == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                var number = inputNums.Where(n => n % 2 != 0).Min();
                                for (int i = inputNums.Count - 1; i >= 0; i--)
                                {
                                    if (inputNums[i] == number)
                                    {
                                        Console.WriteLine(i);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (currentLine.Length == 3)
                {
                    if (currentLine[2] == "even")
                    {
                        if (command == "first")
                        {
                            if (int.Parse(currentLine[1]) > inputNums.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else if (inputNums.Where(n => n % 2 == 0).Count() == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                var takeNums = inputNums.Where(n => n % 2 == 0).Take(int.Parse(currentLine[1])).ToList();
                                Console.WriteLine($"[{string.Join(", ", takeNums)}]");
                            }
                            
                        }
                        else if (command == "last")
                        {
                            var nums = inputNums.Where(n => n % 2 == 0).ToList();
                            if (nums.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else if (int.Parse(currentLine[1]) > inputNums.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else if (nums.Count <= int.Parse(currentLine[1]))
                            {
                                Console.WriteLine($"[{string.Join(", ", nums)}]");
                            }
                            else
                            {
                                var num = int.Parse(currentLine[1]);
                                var skipNums = nums.Count - num;
                                Console.WriteLine($"[{string.Join(", ", nums.Skip(skipNums))}]");
                            }
                        }
                    }
                    else if (currentLine[2] == "odd")
                    {
                        if (command == "first")
                        {
                            if (int.Parse(currentLine[1]) > inputNums.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else if (inputNums.Where(n => n % 2!= 0).Count() == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                var takeNums = inputNums.Where(n => n % 2 != 0).Take(int.Parse(currentLine[1])).ToList();
                                Console.WriteLine($"[{string.Join(", ", takeNums)}]");
                            }
                        }
                        else if (command == "last")
                        {
                            var nums = inputNums.Where(n => n % 2 != 0).ToList();
                            if (nums.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else if (int.Parse(currentLine[1])>inputNums.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else if (nums.Count <= int.Parse(currentLine[1]))
                            {
                                Console.WriteLine($"[{string.Join(", ", nums)}]");
                            }
                            else
                            {
                                var num = int.Parse(currentLine[1]);
                                var skipNums = nums.Count - num;
                                Console.WriteLine($"[{string.Join(", ", nums.Skip(skipNums))}]");
                            }
                        }
                    }
                }   
 
                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ",inputNums)}]");
        }
    }
}
