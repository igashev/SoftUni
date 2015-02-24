using System;
using System.Collections.Generic;

internal class Triangle
{
    private static void Main()
    {
        Dictionary<string, double> coordinates = new Dictionary<string, double>();
        coordinates.Add("aX", double.Parse(Console.ReadLine()));
        coordinates.Add("aY", double.Parse(Console.ReadLine()));
        coordinates.Add("bX", double.Parse(Console.ReadLine()));
        coordinates.Add("bY", double.Parse(Console.ReadLine()));
        coordinates.Add("cX", double.Parse(Console.ReadLine()));
        coordinates.Add("cY", double.Parse(Console.ReadLine()));

        double sideALength = CalculateSideLenght(coordinates["bX"], coordinates["bY"],
            coordinates["cX"], coordinates["cY"]);
        double sideBLenght = CalculateSideLenght(coordinates["aX"], coordinates["aY"],
            coordinates["cX"], coordinates["cY"]);
        double sideCLenght = CalculateSideLenght(coordinates["aX"], coordinates["aY"],
            coordinates["bX"], coordinates["bY"]);

        if (CanFormTriangle(sideALength, sideBLenght, sideCLenght))
        {
            double areaOfTriangle = CalculateArea(sideALength, sideBLenght, sideCLenght);
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", areaOfTriangle);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", sideCLenght);
        }
    }

    private static double CalculateSideLenght(double firstPointXCoordinate, double firstPointYCoordinate,
        double secondPointXCoordinate, double secondPointYCoordinate)
    {
        double length = Math.Sqrt(Math.Pow((secondPointXCoordinate - firstPointXCoordinate), 2) +
            Math.Pow((secondPointYCoordinate - firstPointYCoordinate), 2));

        return length;
    }

    private static bool CanFormTriangle(double a, double b, double c)
    {
        if (a + b > c && b + c > a && a + c > b)
        {
            return true;
        }

        return false;
    }

    private static double CalculateArea(double a, double b, double c)
    {
        double semiperimeter = (a + b + c) / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));

        return area;
    }
}