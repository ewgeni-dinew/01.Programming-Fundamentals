using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_Email_Me
{
    class Program
    {
        static void Main()
        {
            //Task->You will be given an email and you task is to subtract the sum of the characters after the ‘@’ from the sum of the
            //characters before it.
            //If the result is equal or greater than 0 – he will write her an email, otherwise he will not.


            var inputEmail = Console.ReadLine()
                .Split('@');

            int leftSum = 0;
            int rightSum = 0;

            foreach (var letter in inputEmail[0].ToCharArray())
            {
                leftSum += (int)letter;
            }

            foreach (var letter in inputEmail[1].ToCharArray())
            {
                rightSum += (int)letter;
            }

            var result = leftSum - rightSum; 
            
            if (result>=0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
