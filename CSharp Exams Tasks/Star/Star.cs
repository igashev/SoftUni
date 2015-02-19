using System;

public class Star
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int topLinesCount = n / 2;
        int topOuterDotsCount = n;
        int topInnerDotsCount = -1;

        int middleLinesCount = (n / 2) - 1;
        int middleOuterDotsCount = 1;
        int middleInnerDotsCount = ((2 * n) + 1) - 4;

        int bottomLinesCount = n / 2;
        int bottomOuterDotsCount = n / 2;
        int bottomInnerDotsCount = (n / 2) - 1;
        int bottomOuterBetweenDots = -1;

        for (int i = 0; i < topLinesCount; i++)
        {
            PrintTop(topOuterDotsCount, topInnerDotsCount);
            topOuterDotsCount--;
            topInnerDotsCount += 2;
        }

        Console.WriteLine(new string('*', (n / 2) + 1) + new string('.', n - 1) + new string('*', (n / 2) + 1));

        for (int i = 0; i < middleLinesCount; i++)
        {
            PrintMiddle(middleOuterDotsCount, middleInnerDotsCount);
            middleOuterDotsCount++;
            middleInnerDotsCount -= 2;
        }

        for (int i = 0; i < bottomLinesCount; i++)
        {
            PrintBottom(bottomOuterDotsCount, bottomInnerDotsCount, bottomOuterBetweenDots);
            bottomOuterDotsCount--;
            bottomOuterBetweenDots += 2;
        }

        Console.WriteLine(new string('*', (n / 2) + 1) + new string('.', n - 1) + new string('*', (n / 2) + 1));
    }

    private static void PrintTop(int topOuterDots, int topInnerDots)
    {
        for (int i = 0; i < topOuterDots; i++)
        {
            Console.Write('.');
        }

        if (topInnerDots > 0)
        {
            Console.Write('*');
        }

        for (int i = 0; i < topInnerDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < topOuterDots; i++)
        {
             Console.Write('.');
        }

        Console.WriteLine();
    }

    private static void PrintMiddle(int middleOuterDots, int middleInnerDots)
    {
        for (int i = 0; i < middleOuterDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < middleInnerDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < middleOuterDots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }

    private static void PrintBottom(int bottomOuterDots, int bottomInnerDots, int bottomOuterBetweenDots)
    {
        for (int i = 0; i < bottomOuterDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < bottomInnerDots; i++)
        {
            Console.Write('.');
        }

        if (bottomOuterBetweenDots > 0)
        {
            Console.Write('*');
        }

        for (int i = 0; i < bottomOuterBetweenDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < bottomInnerDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < bottomOuterDots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }
}