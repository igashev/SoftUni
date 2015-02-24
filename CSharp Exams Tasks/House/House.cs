using System;

internal class House
{
    private static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int halfHouseHeight = size / 2;
        int topHouseOuterDots = size / 2;
        int topHouseInnerDots = -1;

        int bottomHouseOuterDots = size / 4;
        int bottomHouseInnerDots = size - ((2 * bottomHouseOuterDots) + 2);


        for (int i = 0; i < halfHouseHeight; i++)
        {
            PrintTopOfTheHouse(topHouseOuterDots, topHouseInnerDots);
            topHouseOuterDots--;
            topHouseInnerDots += 2;
        }

        Console.WriteLine(new string('*', size));

        for (int i = 0; i < halfHouseHeight - 1; i++)
        {
            Console.Write(new string('.', bottomHouseOuterDots));
            Console.Write('*');
            Console.Write(new string('.', bottomHouseInnerDots));
            Console.Write('*');
            Console.Write(new string('.', bottomHouseOuterDots));
            Console.WriteLine();
        }

        Console.Write(new string('.', bottomHouseOuterDots));
        Console.Write(new string('*', bottomHouseInnerDots + 2));
        Console.Write(new string('.', bottomHouseOuterDots));
        Console.WriteLine();
    }

    private static void PrintTopOfTheHouse(int outerDots, int innerDots)
    {
        for (int i = 0; i < outerDots; i++)
        {
            Console.Write(".");
        }

            Console.Write("*");

        for (int i = 0; i < innerDots; i++)
        {
            Console.Write(".");
        }

        if (innerDots > 0)
        {
            Console.Write("*");
        }

        for (int i = 0; i < outerDots; i++)
        {
            Console.Write(".");
        }

        Console.WriteLine();
    }
}