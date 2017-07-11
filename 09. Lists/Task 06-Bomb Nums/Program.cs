//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        var inputNums = Console.ReadLine()
//            .Split(' ')
//            .Select(int.Parse)
//            .ToList();

//        var inputBomb = Console.ReadLine()
//            .Split(' ')
//            .Select(int.Parse)
//            .ToArray();

//        int bombNum = inputBomb[0];
//        int bombPower = inputBomb[1];

//        for (int i = 0; i < inputNums.Count; i++)
//        {
//            if (inputNums[i] == bombNum)
//            {
//                int leftIndex = Math.Max(i - bombPower, 0);
//                int rightIndex = Math.Min(i + bombPower, inputNums.Count - 1);

//                inputNums.RemoveRange(i, rightIndex - i);
//                inputNums.RemoveAt(i);
//                inputNums.RemoveRange(leftIndex, i - leftIndex);
//                i = 0;
//            }
//        }
//        Console.WriteLine(inputNums.Sum());
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06_Bomb_Nums
{
    class Program
    {
        static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var bombNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int bombNum = bombNums[0];
            int bombPower = bombNums[1];

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == bombNum)
                {
                    var rightIndex = Math.Min(i + bombPower, inputNumbers.Count - 1);
                    var leftIndex = Math.Max(0, i - bombPower);
                    inputNumbers.RemoveRange()
                }
            }
            Console.WriteLine(inputNumbers.Sum());
        }
    }
}
