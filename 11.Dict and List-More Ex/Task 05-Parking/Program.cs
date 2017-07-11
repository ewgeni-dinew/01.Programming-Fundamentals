using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Parking
{
    class Program
    {
        static void Main()
        {
            //Task->Write a program, which validates parking for an online service. Users can register to park and unregister to leave.
            //The system supports license plate validation. A valid license plate has 3 distinct characteristics:
            //*It is always exactly 8 characters long;*Its first 2 and last 2 characters are always uppercase letters;*The 4 characters in the middle are always digits
            //The program receives 2 commands:


            var registeredUsers = new Dictionary<string, string>();
         
            var inputAmmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputAmmount; i++)
            {
                var currentPlate = Console.ReadLine()
                    .Split(' ');

                var command = currentPlate[0];
                var name = currentPlate[1];

                if (command=="register")
                {
                    var plate = currentPlate[2];

                    
                    if (registeredUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registeredUsers[name]}");
                    }
                    else if (!DoesPlateExist(plate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }
                    else if (registeredUsers.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }

                    else
                    {
                        registeredUsers[name] = plate;
                        Console.WriteLine($"{name} registered {plate} successfully");            
                    }
                    
                }
                else 
                {
                    if (!registeredUsers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {name} unregistered successfully");
                        registeredUsers.Remove(name);
                        
                    }
                }
            }
            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        public static bool DoesPlateExist(string currentPlate)
        {
            if (currentPlate.Length==8 && currentPlate.Take(2).All(char.IsUpper)
                &&currentPlate.Skip(6).All(char.IsUpper)&&currentPlate.Skip(2).Take(4).All(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
