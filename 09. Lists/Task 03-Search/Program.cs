using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Search
{
    class Program
    {
        static void Main()
        {
            //Task->On the first line, you will receive a list of integers. On the next line, you will receive an array with exactly three nums.
            //First number represents the number of elements you have to take from the list (starting from the first one).
            //Second number represents the number of elements you have to delete from the numbers you took (starting from the first one).
            //Last number is the number we search in our collection after the manipulations.
            //If it is present print: “YES!”, otherwise print “NO!”.

            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var removeNumsCriteria= Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var removeFirstNums = removeNumsCriteria[0];
            var removeSecondNums = removeNumsCriteria[1];
            var mathNum = removeNumsCriteria[2];

            inputNums.Take(removeFirstNums);
            inputNums.RemoveRange(0, removeSecondNums);

            bool matchedNum = false; 
            for (int i = 0; i < inputNums.Count; i++)
            {
                if (inputNums[i]==mathNum)
                {
                    Console.WriteLine("YES!");
                    matchedNum = true;
                    break;
                }
            }
            if (matchedNum==false)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
