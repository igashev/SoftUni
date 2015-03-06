using System;
using System.Collections.Generic;

public class BitRoller
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int positionToFreeze = int.Parse(Console.ReadLine());
        int rollsCount = int.Parse(Console.ReadLine());
        string binaryNumber = Convert.ToString(number, 2).PadLeft(19, '0');
        List<char> binaryNumberAsList = ConvertBinaryToCharList(binaryNumber);
        char FrozenBit = binaryNumberAsList[binaryNumberAsList.Count - positionToFreeze - 1];

        binaryNumberAsList.RemoveAt(binaryNumberAsList.Count - positionToFreeze - 1);

        for (int i = 0; i < rollsCount; i++)
        {
            binaryNumberAsList.Insert(0, binaryNumberAsList[binaryNumberAsList.Count - 1]);
            binaryNumberAsList.RemoveAt(binaryNumberAsList.Count - 1);
        }

        binaryNumberAsList.Insert(binaryNumberAsList.Count - positionToFreeze, FrozenBit);

        int result = ConvertBinaryListToInt(binaryNumberAsList);

        Console.WriteLine(result);
    }

    private static List<char> ConvertBinaryToCharList(string binaryNumber)
    {
        List<char> binaryList = new List<char>();

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            binaryList.Add(binaryNumber[i]);
        }

        return binaryList;
    }

    private static int ConvertBinaryListToInt(List<char> binaryNumber)
    {
        string binary = string.Empty;

        for (int i = 0; i < binaryNumber.Count; i++)
        {
            binary += binaryNumber[i];
        }

        return Convert.ToInt32(binary, 2);
    }
}