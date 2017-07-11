using System;
using System.Linq;

class AdditionAlgorithm
{
    static void Main()
    {
        //Таск->You are given two lines - each can be a really big number (0 to 10^50). 
        //You must display the sum of these numbers.

        string firstString = Console.ReadLine().Trim();
        string secondString = Console.ReadLine().Trim();

        Console.WriteLine(Add(firstString, secondString));

    }

    public static string Add(string a, string b)
    {
        int maxLen = Math.Max(a.Length, b.Length);
        a = a.PadLeft(maxLen + 1, '0');
        b = b.PadLeft(maxLen + 1, '0');

        int[] arr1 = a.Select(x => int.Parse(x.ToString())).ToArray();
        int[] arr2 = b.Select(x => int.Parse(x.ToString())).ToArray();
        int[] sum = new int[arr1.Length];

        int carry = 0;
        for (int i = sum.Length - 1; i >= 0; i--)
        {
            int total = arr1[i] + arr2[i] + carry;
            sum[i] = total % 10;
            if (total > 9) carry = 1;
            else carry = 0;
        }
        return string.Join("", sum.SkipWhile(x => x == 0));
    }
}