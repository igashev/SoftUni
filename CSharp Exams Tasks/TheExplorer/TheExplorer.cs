using System;

public class TheExplorer
{
    public static void Main()
    {
        int dashes = int.Parse(Console.ReadLine());
        int outSideDashes = (dashes / 2) - 1;
        int insideDashes = 1;

        string firstAndLastLine = new string('-', dashes / 2);

        Console.WriteLine("{0}{1}{0}", firstAndLastLine, '*');

        while (true)
        {
            PrintLine(outSideDashes, insideDashes);
            Console.WriteLine();
            outSideDashes--;
            insideDashes += 2;

            if (outSideDashes == -1)
            {
                break;
            }
        }

        insideDashes -= 2;
        outSideDashes += 1;

        while (true)
        {
            outSideDashes++;
            insideDashes -= 2;
            PrintLine(outSideDashes, insideDashes);
            Console.WriteLine();

            if (outSideDashes == (dashes / 2) - 1)
            {
                break;
            }
        }

        Console.WriteLine("{0}{1}{0}", firstAndLastLine, '*');
    }

    private static void PrintLine(int outsideDashes, int insideDashes)
    {
        for (int i = 0; i < outsideDashes; i++)
        {
            Console.Write('-');
        }

        Console.Write('*');

        for (int i = 0; i < insideDashes; i++)
        {
            Console.Write('-');
        }

        Console.Write('*');

        for (int i = 0; i < outsideDashes; i++)
        {
            Console.Write('-');
        }
    }
}
