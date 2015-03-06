using System;
using System.Collections.Generic;
using System.Text;

public class FiveSpecialLetters
{
    private static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        bool hasValues = false;

        for (char i = 'a'; i <= 'e'; i++)
        {
            for (char i2 = 'a'; i2 <= 'e'; i2++)
            {
                for (char i3 = 'a'; i3 <= 'e'; i3++)
                {
                    for (char i4 = 'a'; i4 <= 'e'; i4++)
                    {
                        for (char i5 = 'a'; i5 <= 'e'; i5++)
                        {
                            StringBuilder sequence = new StringBuilder();
                            sequence.Append(i).Append(i2).Append(i3).Append(i4).Append(i5);

                            string finalSequence = RemoveDuplicateChars(sequence);
                            int weight = CalculatingWeightOfWord(finalSequence);

                            if (weight >= start && weight <= end)
                            {
                                hasValues = true;
                                Console.Write(sequence + " ");
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine();

        if (!hasValues)
        {
            Console.WriteLine("No");
        }
    }

    private static string RemoveDuplicateChars(StringBuilder sequence)
    {
        List<char> result = new List<char>();

        for (int i = 0; i < sequence.Length; i++)
        {
            if (!result.Contains(sequence[i]))
            {
                result.Add(sequence[i]);
            }
        }

        return string.Join("", result);
    }

    private static int CalculatingWeightOfWord(string sequence)
    {
        int weight = 0;
        int multiplier = 1;

        for (int i = 0; i < sequence.Length; i++)
        {
            switch (sequence[i])
            {
                case 'a':
                    weight += multiplier * 5;
                    multiplier++;
                    break;
                case 'b':
                    weight += multiplier * -12;
                    multiplier++;
                    break;
                case 'c':
                    weight += multiplier * 47;
                    multiplier++;
                    break;
                case 'd':
                    weight += multiplier * 7;
                    multiplier++;
                    break;
                case 'e':
                    weight += multiplier * -32;
                    multiplier++;
                    break;
            }
        }

        return weight;
    }
}