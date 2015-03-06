using System;

public class Arrow
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDotsCount = n / 2;
        int innerDotsCount = n - 2;
        int middleLineNumberSignCount = (n / 2) + 1;
        int fullWidth = n + (2 * outerDotsCount);
        int bottomOuterDotsCount = 1;
        int bottomInnerDotsCount = fullWidth - 4;

        string firstLine = new string('.', outerDotsCount) + new string('#', n) + new string('.', outerDotsCount);
        string top = new string('.', outerDotsCount) + "#" + new string('.', innerDotsCount) + "#" + new string('.', outerDotsCount);
        string middleLine = new string('#', middleLineNumberSignCount) + 
            new string('.', innerDotsCount) + new string('#', middleLineNumberSignCount);
        string bottom = new string('.', bottomOuterDotsCount) + "#" + 
            new string('.', bottomInnerDotsCount) + "#" + new string('.', bottomOuterDotsCount);

        Console.WriteLine(firstLine);

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(top);
        }

        Console.WriteLine(middleLine);

        for (int i = 0; i < n - 1; i++)
        {
            PrintBottom(bottomOuterDotsCount, bottomInnerDotsCount);
            bottomOuterDotsCount++;
            bottomInnerDotsCount -= 2;
        }
    }

    private static void PrintBottom(int outerDots, int innerDots)
    {
        for (int i = 0; i < outerDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('#');

        for (int i = 0; i < innerDots; i++)
        {
            Console.Write('.');
        }

        if (innerDots != -1)
        {
            Console.Write('#');
        }

        for (int i = 0; i < outerDots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }
}