using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Employee_Data
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            short age = short.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long numberID = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0} \n Last name: {1} \n Age: {2} \n Gender: {3} \n Personal ID: {4} \n Unique Employee number: {5}",firstName,secondName,age,gender,numberID,employeeNumber);
        }
    }
}
