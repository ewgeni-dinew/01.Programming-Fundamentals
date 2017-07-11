using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_Max_Sequence
{
    class Program
    {
        static void Main()
        {
            
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < inputNums.Count; i++)
            {
                if (inputNums[i]<0)
                {
                    inputNums.RemoveAt(i);
                }
            }
            inputNums.Reverse();
            Console.WriteLine(string.Join(",",inputNums));

            




      
             
         
        

        }
    }
}