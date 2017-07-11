using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_04_Roli
{
    class Program
    {
        static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse)
                .OrderBy(a=>a.Name)
                .ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }

        public static Demon Parse(string demonStr)
        {
            var name = demonStr;
            var damageRegex =new Regex(@"-?\d+(?:\.\d+)?");
            var healthRegex = new Regex(@"[^\d\-*\/\.]");
            var health = healthRegex
                .Matches(demonStr)
                .Cast<Match>()
                .Select(a=>(int)char.Parse(a.Value))
                .Sum();

            var damage = damageRegex
                .Matches(demonStr)
                .Cast<Match>()
                .Select(a => decimal.Parse(a.Value))
                .Sum();

            var multiply = demonStr.Count(a => a == '*');
            var divide = demonStr.Count(a => a == '/');

            damage *= (int)Math.Pow(2, multiply);
            damage /= (int)Math.Pow(2, divide);


            var demon = new Demon()
            {
                Name = name,
                Health = health,
                Damage = damage
                
            };
            return demon;
        }
    }
}
