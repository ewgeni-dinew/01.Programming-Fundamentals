using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07_Primes_In_Given_Range
{
    class Program
    {
        public static string PrimesInRange(List<int> listOfNums ,int endNum,int startNum)
        {
            var removeNums = new int[] { 0, 1 };
            for (int j = startNum; j <= endNum; j++)
            {
                listOfNums.Add(j);
            }

            for (int i = startNum; i <= endNum; i++)
            {
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        listOfNums.Remove(i);
                    }
                }
            }
            if (listOfNums.Contains(0)|| listOfNums.Contains(1))
            {
                listOfNums.Remove(0);
                listOfNums.Remove(1);
            }
            return string.Join(", ", listOfNums);

        }
        static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var listOfNums = new List<int>();
            
            Console.WriteLine(PrimesInRange(listOfNums,endNum,startNum));
        }
    }
}
