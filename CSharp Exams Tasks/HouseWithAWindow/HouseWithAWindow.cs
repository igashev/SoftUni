namespace HouseWithAWindow
{
    using System;

    public class HouseWithAWindow
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int topOuterDotsCount = n - 1;
            int topInnerDotsCount = -1;

            for (int i = 0; i < n; i++)
            {
                PrintTop(topOuterDotsCount, topInnerDotsCount);

                topOuterDotsCount--;
                topInnerDotsCount += 2;
            }

            string middleAndBottom = new string('*', (2 * n) - 1);

            Console.WriteLine(middleAndBottom);
            PrintBottom(n);
            Console.WriteLine(middleAndBottom);
        }

        private static void PrintTop(int outerDots, int innerDots)
        {
            for (int i = 0; i < outerDots; i++)
            {
                Console.Write(".");
            }

            if (innerDots > 0)
            {
                Console.Write("*");
            }

            for (int i = 0; i < innerDots; i++)
            {
                Console.Write(".");
            }

            Console.Write("*");

            for (int i = 0; i < outerDots; i++)
            {
                Console.Write(".");
            }

            Console.WriteLine();
        }

        private static void PrintBottom(int n)
        {
            int windowHeight = n / 2;
            int windowWidth = n - 3;

            string noWindowPart = "*" + new string('.', (2 * n) - 3) + "*";
            int noWindowPartHeight = (n - windowHeight) / 2;

            for (int i = 0; i < noWindowPartHeight; i++)
            {
                Console.WriteLine(noWindowPart);
            }

            string windowPart = "*" + new string('.', n / 2) + new string('*', windowWidth) + new string('.', n / 2) + "*";

            for (int i = 0; i < windowHeight; i++)
            {
                Console.WriteLine(windowPart);
            }

            for (int i = 0; i < noWindowPartHeight; i++)
            {
                Console.WriteLine(noWindowPart);
            }
        }
    }
}
