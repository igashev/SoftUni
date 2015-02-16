using System;
using System.Collections.Generic;

public class MagicStrings
{
    public static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        string[] letters = { "s", "n", "k", "p" };
        int[] weights = { 3, 4, 1, 5 };
        int lettersLength = letters.Length;
        List<string> sequences = new List<string>();

        for (int firstLoop = 0; firstLoop < lettersLength; firstLoop++)
        {
            for (int secondLoop = 0; secondLoop < lettersLength; secondLoop++)
            {
                for (int thirdLoop = 0; thirdLoop < lettersLength; thirdLoop++)
                {
                    for (int fourthLoop = 0; fourthLoop < lettersLength; fourthLoop++)
                    {
                        for (int fifthLoop = 0; fifthLoop < lettersLength; fifthLoop++)
                        {
                            for (int sixthLoop = 0; sixthLoop < lettersLength; sixthLoop++)
                            {
                                for (int seventhLoop = 0; seventhLoop < lettersLength; seventhLoop++)
                                {
                                    for (int eighthLoop = 0; eighthLoop < lettersLength; eighthLoop++)
                                    {
                                        int firstHalfSum = weights[firstLoop] + weights[secondLoop] + weights[thirdLoop] + weights[fourthLoop];
                                        int secondHalfSum = weights[fifthLoop] + weights[sixthLoop] + weights[seventhLoop] + weights[eighthLoop];

                                        if (Math.Abs(firstHalfSum - secondHalfSum) == diff)
                                        {
                                            string sequence = letters[firstLoop] + letters[secondLoop] + letters[thirdLoop] + letters[fourthLoop] +
                                                letters[fifthLoop] + letters[sixthLoop] + letters[seventhLoop] + letters[eighthLoop];
                                            sequences.Add(sequence);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        sequences.Sort();
        if (sequences.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            foreach (string sequence in sequences)
            {
                Console.WriteLine(sequence);
            }
        }
    }
}
