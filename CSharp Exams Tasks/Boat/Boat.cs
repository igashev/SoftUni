using System;

public class Boat
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sailAsterixes = 1;
        int leftSideSailDots = n;
        int rightSideSailDots = n;

        int bodyDots = 0;
        int bodyAsterixes = 2 * n;

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            PrintSail(sailAsterixes, leftSideSailDots, rightSideSailDots);
            leftSideSailDots -= 2;
            sailAsterixes += 2;
        }

        leftSideSailDots += 2;
        sailAsterixes -= 2;

        for (int i = 0; i < (n / 2); i++)
        {
            leftSideSailDots += 2;
            sailAsterixes -= 2;
            PrintSail(sailAsterixes, leftSideSailDots, rightSideSailDots);
        }

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            PrintBody(bodyDots, bodyAsterixes);
            bodyDots++;
            bodyAsterixes -= 2;
        }
    }

    private static void PrintSail(int asterixes, int leftsSideDots, int rightSideDots)
    {
        for (int i = 0; i < leftsSideDots - 1; i++)
        {
            Console.Write('.');
        }

        for (int i = 0; i < asterixes; i++)
        {
            Console.Write('*');
        }

        for (int i = 0; i < rightSideDots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }

    private static void PrintBody(int dots, int asterixes)
    {
        for (int i = 0; i < dots; i++)
        {
            Console.Write('.');
        }

        for (int i = 0; i < asterixes; i++)
        {
            Console.Write('*');
        }

        for (int i = 0; i < dots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }
}