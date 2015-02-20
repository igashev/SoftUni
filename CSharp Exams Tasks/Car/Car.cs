using System;

public class Car
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string topFirstLine = string.Format(new string('.', n) + new string('*', n) + new string('.', n));
        int topLinesCount = (n / 2) - 1;
        int topOuterDotsCount = n - 1;
        int topInnerDotsCount = n;

        string middleFirstLine = string.Format(new string('*', (n / 2) + 1) + 
            new string('.', (3 * n) - (2 * ((n / 2) + 1))) +
            new string('*', (n / 2) + 1));
        int middleLinesCount = (n / 2) - 2;
        int middleInnerDotsCount = (3 * n) - 2;
        string middleLastLine = new string('*', 3 * n);

        int bottomLinesCount = (n / 2) - 2;
        int bottomOuterDotsCount = n / 2;
        int bottomInnerDotsCount = (n / 2) - 1;
        int bottomMiddleDotsCount = n - 2;
        string bottom = string.Format(
            new string('.', bottomOuterDotsCount) + '*' + 
            new string('.', bottomInnerDotsCount) + '*' + 
            new string('.', bottomMiddleDotsCount) + '*' + 
            new string('.', bottomInnerDotsCount) + '*' + 
            new string('.', bottomOuterDotsCount));
        int bottomLastLineAsterisksCount = (n / 2) + 1;
        string bottomLastLine = string.Format(
            new string('.', bottomOuterDotsCount) + 
            new string('*', bottomLastLineAsterisksCount) +
            new string('.', bottomMiddleDotsCount) + 
            new string('*', bottomLastLineAsterisksCount) + 
            new string('.', bottomOuterDotsCount));

        Console.WriteLine(topFirstLine);
        for (int i = 0; i < topLinesCount; i++)
        {
             PrintTopCar(topOuterDotsCount, topInnerDotsCount);
             topOuterDotsCount--;
             topInnerDotsCount += 2;
        }

        Console.WriteLine(middleFirstLine);
        for (int i = 0; i < middleLinesCount; i++)
        {
            PrintMiddle(middleInnerDotsCount);
        }

        Console.WriteLine(middleLastLine);

        for (int i = 0; i < bottomLinesCount; i++)
        {
            Console.WriteLine(bottom);
        }

        Console.WriteLine(bottomLastLine);
    }

    private static void PrintTopCar(int topOuterDotsCount, int topInnerDotsCount)
    {
        for (int i = 0; i < topOuterDotsCount; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < topInnerDotsCount; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < topOuterDotsCount; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }

    private static void PrintMiddle(int middleInnerDotsCount)
    {
        Console.Write('*');

        for (int i = 0; i < middleInnerDotsCount; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        Console.WriteLine();
    }
}
