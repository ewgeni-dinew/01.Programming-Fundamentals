using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_01_Extract_Emails
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program to extract all email addresses from a given text. The text comes at the only input line.
            //Print theemails on the console, each at a separate line. 
            //Emails are considered to be in format <user>@<host>
            
            var inputText = Console.ReadLine();
            var pattern = @"(?<=\s)[a-z0-9]+([.-]\w*)*@[a-z]+([.-]\w*)*(\.[a-z]+)";
            
            var emails = Regex.Matches(inputText, pattern);
           
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
