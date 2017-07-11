using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05_Hands_of_Cards
{
    class Program
    {
        static void Main()
        {
            //Task->You are given a sequence of people and for every person what cards he draws from the deck.
            //The input will be separate lines in the format:
            //{personName}: { PT, PT, PT,… PT}
            //Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type.
            //The input ends when a "JOKER" is drawn.The name can contain any ASCII symbol except ':'.
            //A single person cannot have more than one card with the same power and type, if he draws such a card he discards it.
            //The people are playing with multiple decks.Each card has a value that is calculated by the power multiplied by the type.
            //Powers 2 to 10 have the same value and J to A are 11 to 14.Types are mapped to multipliers the following way(S-> 4, H-> 3, D-> 2, C-> 1).
            //Finally print out the total value each player has in his hand

            var cardPowers = GetCardPowers();
            var cardTypes = GetCardTypes();

            var cards = new Dictionary<string, HashSet<int>>();

            var inputValue = Console.ReadLine();
            while (inputValue!="JOKER")
            {
                var tokens = inputValue.Split(':');
                var playerName = tokens[0];
                var playerCards = tokens[1]
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0,card.Length-1);
                    var cardType = card.Substring(card.Length-1);

                    var sum = cardPowers[cardPower] * cardTypes[cardType];
                    if (!cards.ContainsKey(playerName))
                    {
                        cards[playerName] = new HashSet<int>();
                    }
                    cards[playerName].Add(sum);
                }
                inputValue = Console.ReadLine();
            }
            foreach (var pair in cards)
            {
                var name = pair.Key;
                var cardsSum = pair.Value.Sum();
                Console.WriteLine($"{name}: {cardsSum}");
            }
        }

        private static Dictionary<string,int> GetCardPowers()
        {
            var powers = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }

            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            return powers;
        }

        private static Dictionary<string, int> GetCardTypes()
        {
            var types = new Dictionary<string, int>();
            types["S"] = 4;
            types["H"] = 3;
            types["D"] = 2;
            types["C"] = 1;

            return types;
        }
    }
}
