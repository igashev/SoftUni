using System;
using System.Collections.Generic;

internal class BitKiller
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        List<char> bits = new List<char>();
        List<char> bitsLeftOver = new List<char>(bits.Count);
        int indexToRemove = 1;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2).PadLeft(8, '0');

            foreach (char bit in binary)
            {
                bits.Add(bit);
            }
        }

        for (int i = 0; i < bits.Count; i++)
        {
            if (i != indexToRemove)
            {
                bitsLeftOver.Add(bits[i]);
            }
            else
            {
                indexToRemove += step;
            }
        }

        while (bitsLeftOver.Count % 8 != 0)
        {
            bitsLeftOver.Add('0');
        }

        string result = string.Empty;

        for (int i = 0; i < bitsLeftOver.Count; i++)
        {
            result += bitsLeftOver[i];

            if (result.Length == 8)
            {
                Console.WriteLine(Convert.ToInt32(result, 2));
                result = string.Empty;
            }
        }
    }
}