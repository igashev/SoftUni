using System;

public class NewHouse
{
    public static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int dashes = height / 2;
        int asterixes = 1;

        while (dashes >= 0)
        {
            PrintRoof(dashes, asterixes);
            Console.WriteLine();
            dashes--;
            asterixes += 2;
        }

        for (int i = 0; i < height; i++)
        {
            Console.Write('|');
            for (int j = 0; j < height - 2; j++)
            {
                Console.Write('*');
            }

            Console.Write('|');
            Console.WriteLine();
        }
    }

    private static void PrintRoof(int dashes, int asterixes)
    {
        for (int i = 0; i < dashes; i++)
        {
            Console.Write('-');
        }

        for (int i = 0; i < asterixes; i++)
        {
            Console.Write('*');
        }

        for (int i = 0; i < dashes; i++)
        {
            Console.Write('-');
        }
    }
}