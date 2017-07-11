using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Multiply_Nums
{
    class Program
    {
        static void Main()
        {
            //Task->You are given two lines – the first one can be a really big number (0 to 1050).
            //The second one will be a single digit number (0 to 9). 
            //You must display the product of these numbers.


            var inputFirstString = Console.ReadLine();
            var inputMultiplier = int.Parse(Console.ReadLine());
            var numList = new string[inputFirstString.Length + 1];
            inputFirstString = inputFirstString.PadLeft(inputFirstString.Length + 1, '0');
            int surplus = 0;

            for (int i = inputFirstString.Length-1; i >=0; i--)
            {
                
                var currentCalc = inputMultiplier * (int.Parse(inputFirstString[i].ToString()))+surplus;
                if (currentCalc>9)
                {
                    surplus = (currentCalc - currentCalc % 10)/10;
                    currentCalc = currentCalc % 10;                   
                }
                else
                {                    
                    surplus = 0;
                }
                numList[i] = currentCalc.ToString();
            }

            if (numList[0]=="0")
            {
                Console.WriteLine(string.Join("", numList.Skip(1)));
            }
            else
            {
                Console.WriteLine(string.Join("",numList));
            }
        }
    }
}
