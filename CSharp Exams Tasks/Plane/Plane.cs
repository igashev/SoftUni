using System;

public class Plane
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int frontPlaneSize = n + 1;
        int frontPlaneOuterDots = (3 * n) / 2;
        int frontPlaneInnerDots = -1;

        int bodyDots = n;

        int middlePlaneSize = n / 2;
        int middlePlaneWingInnerDots = n - 2;
        int middlePlaneWingOuterDots = -1;

        int rearPlaneSize = n - 1;
        int rearPlaneOuterDots = n - 1;
        int rearPlaneInnerDots = n;

        for (int i = 0; i < frontPlaneSize; i++)
        {
            if (i < (frontPlaneSize / 2) + 1)
            {
                PrintFrontPlane(frontPlaneOuterDots, frontPlaneInnerDots);
                frontPlaneOuterDots--;
                frontPlaneInnerDots += 2;
            }
            else
            {
                PrintFrontPlane(frontPlaneOuterDots, frontPlaneInnerDots);
                frontPlaneOuterDots -= 2;
                frontPlaneInnerDots += 4;
            }
        }

        for (int i = 0; i < middlePlaneSize; i++)
        {
            PrintMiddlePlane(middlePlaneWingInnerDots, middlePlaneWingOuterDots, bodyDots);
            middlePlaneWingInnerDots -= 2;
            middlePlaneWingOuterDots += 2;
        }

        for (int i = 0; i < rearPlaneSize; i++)
        {
            PrintRearPlane(rearPlaneOuterDots, rearPlaneInnerDots);
            rearPlaneOuterDots--;
            rearPlaneInnerDots += 2;
        }

        Console.WriteLine(new string('*', 3 * n));
    }

    private static void PrintFrontPlane(int outerDots, int innerDots)
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

        if (innerDots > 0)
        {
            Console.Write('*');
        }

        for (int i = 0; i < outerDots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }

    private static void PrintMiddlePlane(int innerWingDots, int outerWingDots, int bodyDots)
    {
        Console.Write('*');

        for (int i = 0; i < innerWingDots; i++)
        {
            Console.Write('.');
        }

        if (outerWingDots > 0)
        {
            Console.Write('*');
        }

        for (int i = 0; i < outerWingDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < bodyDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < outerWingDots; i++)
        {
            Console.Write('.');
        }

        if (outerWingDots > 0)
        {
            Console.Write('*');
        }

        for (int i = 0; i < innerWingDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');
        Console.WriteLine();
    }

    private static void PrintRearPlane(int outerRearDots, int innerRearDots)
    {
        for (int i = 0; i < outerRearDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < innerRearDots; i++)
        {
            Console.Write('.');
        }

        Console.Write('*');

        for (int i = 0; i < outerRearDots; i++)
        {
            Console.Write('.');
        }

        Console.WriteLine();
    }
}