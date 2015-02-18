using System;

public class RockLq
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int topOuterDotsCount = n - 2;
        int topInnerDotsCount = n + 2;

        int sleeveInnerDotsCount = n - 2;
        int sleeveOuterDotsCount = -1;

        int bodyDotsCount = n;

        int bottomOuterDotsCount = n - 1;

        PrintFirstLineOfRocklq(n);

        for (int i = 0; i < n / 2; i++)
        {
            PrintTopOfRocklq(topOuterDotsCount, topInnerDotsCount);
            topOuterDotsCount -= 2;
            topInnerDotsCount += 4;
        }

        for (int i = 0; i < n / 2; i++)
        {
            PrintMiddleOfRocklq(sleeveInnerDotsCount, bodyDotsCount, sleeveOuterDotsCount);
            sleeveInnerDotsCount -= 2;
            sleeveOuterDotsCount += 2;
        }

        for (int i = 0; i < n - 1; i++)
        {
            PrintBottomOfRocklq(bottomOuterDotsCount, bodyDotsCount);
            bottomOuterDotsCount--;
            bodyDotsCount += 2;
        }

        Console.WriteLine(new string('*', 3 * n));
    }

    private static void PrintFirstLineOfRocklq(int width)
    {
        string dots = new string('.', width);
        string asterixes = new string('*', width);

        Console.WriteLine("{0}{1}{0}", dots, asterixes, dots);
    }

    private static void PrintTopOfRocklq(int outerDots, int innerDots)
    {
        for (int i = 0; i < outerDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < innerDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < outerDots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }

    private static void PrintMiddleOfRocklq(int innerSleeveDots, int bodyDots, int outerSleeveDots)
    {
        Console.Write('*');

        for (int i = 0; i < innerSleeveDots; i++)
        {
            Console.Write('.');
        }

        if (outerSleeveDots > 0)
        {
            Console.Write('*');
        }

        for (int i = 0; i < outerSleeveDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < bodyDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < outerSleeveDots; i++)
        {
            Console.Write('.');
        }

        if (outerSleeveDots > 0)
        {
            Console.Write('*');
        }

        for (int i = 0; i < innerSleeveDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        Console.WriteLine();
    }

    private static void PrintBottomOfRocklq(int outerBottomDots, int bodyDots)
    {
        for (int i = 0; i < outerBottomDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < bodyDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < outerBottomDots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }
}