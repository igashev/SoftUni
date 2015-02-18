using System;

public class Headphones
{
    public static void Main()
    {
        int diameter = int.Parse(Console.ReadLine());
        int outerDashesCount = diameter / 2;
        int innerDashesCount = diameter;
        int asterixesCount = 1;

        FirstLineHeadband(diameter, outerDashesCount);

        for (int i = 0; i < diameter - 1; i++)
        {
            RestOfTheHeadphones(asterixesCount, outerDashesCount, innerDashesCount);
        }

        for (int i = 0; i < diameter / 2; i++)
        {
            RestOfTheHeadphones(asterixesCount, outerDashesCount, innerDashesCount);
            outerDashesCount--;
            asterixesCount += 2;
            innerDashesCount -= 2;
        }

        MiddleLineOfHeadphones(diameter);

        for (int i = 0; i < diameter / 2; i++)
        {
            outerDashesCount++;
            asterixesCount -= 2;
            innerDashesCount += 2;
            RestOfTheHeadphones(asterixesCount, outerDashesCount, innerDashesCount);
        }
    }

    private static void FirstLineHeadband(int diameter, int outerDashes)
    {
        string firstLineDashes = new string('-', outerDashes);
        string firstLineAsterixes = new string('*', diameter + 2);
        Console.WriteLine("{0}{1}{0}", firstLineDashes, firstLineAsterixes);
    }

    private static void RestOfTheHeadphones(int asterixes, int outerDashes, int innerDashes)
    {
        for (int i = 0; i < outerDashes; i++)
        {
            Console.Write('-');
        }

        for (int i = 0; i < asterixes; i++)
        {
            Console.Write('*');
        }

        for (int i = 0; i < innerDashes; i++)
        {
            Console.Write('-');
        }

        for (int i = 0; i < asterixes; i++)
        {
            Console.Write('*');
        }

        for (int i = 0; i < outerDashes; i++)
        {
            Console.Write('-');
        }

        Console.WriteLine();
    }

    private static void MiddleLineOfHeadphones(int diameter)
    {
        string asterixes = new string('*', diameter);

        Console.WriteLine("{0}-{0}", asterixes);
    }
}