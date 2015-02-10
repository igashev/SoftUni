using System;

public class Sunglasses
{
    public static void Main()
    {
        int heightOfSunglasses = int.Parse(Console.ReadLine());

        for (int i = 0; i < heightOfSunglasses; i++)
        {
            if (i == 0 || i == heightOfSunglasses - 1)
            {
                PrintTopAndBottom(heightOfSunglasses);
            }
            else
            {
                PrintLensAndBridge(heightOfSunglasses, i);
            }
        }
    }

    private static void PrintTopAndBottom(int n)
    {
        string frame = new string('*', 2 * n);
        string spaceBetweenTwoFrames = new string(' ', n);

        Console.WriteLine("{0}{1}{0}", frame, spaceBetweenTwoFrames);
    }

    private static void PrintLensAndBridge(int n, int i)
    {
        string lens = new string('/', 2 * n - 2);
        string frame = string.Format("{0}{1}{0}", '*', lens);
        string bridge = new string(' ', n);

        if (i == n / 2)
        {
            bridge = new string('|', n);
        }

        Console.WriteLine("{0}{1}{0}", frame, bridge);
    }
}