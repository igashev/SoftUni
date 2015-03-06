using System;
using System.Collections.Generic;

public class OddEvenElements
{
    private static void Main()
    {
        string[] userInput = Console.ReadLine().Split(' ');
        double[] numbers = Array.ConvertAll(userInput, double.Parse);
        List<double> oddNumbers = new List<double>();
        List<double> evenNumbers = new List<double>();

        double oddSum = 0;
        double oddMin;
        double oddMax;

        double evenSum = 0;
        double evenMin;
        double evenMax;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddSum += numbers[i];
                oddNumbers.Add(numbers[i]);
            }
            else
            {
                evenSum += numbers[i];
                evenNumbers.Add(numbers[i]);
            }
        }

        oddNumbers.Sort();
        evenNumbers.Sort();


        if (oddNumbers.Count > 0)
        {
            oddMin = oddNumbers[0];
            oddMax = oddNumbers[oddNumbers.Count - 1];

            Console.Write("OddSum={0:0.##}, ", oddSum);
            Console.Write("OddMin={0:0.##}, ", oddMin);
            Console.Write("OddMax={0:0.##}, ", oddMax);
        }
        else
        {
            Console.Write("OddSum=No, ");
            Console.Write("OddMin=No, ");
            Console.Write("OddMax=No");
        }

        if (evenNumbers.Count > 0)
        {
            evenMin = evenNumbers[0];
            evenMax = evenNumbers[evenNumbers.Count - 1];

            Console.Write("EvenSum={0:0.##}, ", evenSum);
            Console.Write("EvenMin={0:0.##}, ", evenMin);
            Console.Write("EvenMax={0:0.##}", evenMax);
        }
        else
        {
            Console.Write("EvenSum=No, ");
            Console.Write("EvenMin=No, ");
            Console.Write("EvenMax=No");
        }

        Console.WriteLine();
    }
}