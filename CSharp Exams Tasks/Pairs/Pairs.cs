using System;
using System.Collections.Generic;

internal class Pairs
{
    private static void Main()
    {
        string[] userInputNumbers = Console.ReadLine().Split(' ');
        int[] userDigits = Array.ConvertAll(userInputNumbers, int.Parse);
        int sum = userDigits[0] + userDigits[1];
        int counter = 0;
        List<int> diffCounter = new List<int>();

        for (int i = 0; i < userDigits.Length - 1; i += 2)
        {
            if ((userDigits[i] + userDigits[i + 1]) != sum)
            {
                if (i == 2)
                {
                    diffCounter.Add(sum);
                }

                diffCounter.Add(userDigits[i] + userDigits[i + 1]);
            }
            else
            {
                counter++;
            }
        }

        if (counter == userDigits.Length / 2)
        {
            Console.WriteLine("Yes, value=" + sum);
        }
        else
        {
            diffCounter.Sort();
            int difference = diffCounter[diffCounter.Count - 1] - diffCounter[0];
            Console.WriteLine("No, maxdiff=" + difference);
        }
    }
}