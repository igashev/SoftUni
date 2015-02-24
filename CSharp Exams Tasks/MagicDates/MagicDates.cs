using System;
using System.Collections.Generic;

internal class MagicDates
{
    private static void Main()
    {
        int startingYear = int.Parse(Console.ReadLine());
        int endingYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        DateTime startingYearDate = new DateTime(startingYear, 01, 01);
        DateTime endingYearDate = new DateTime(endingYear, 12, 31).AddDays(1.0);

        List<DateTime> magicDates = GetMagicDates(startingYearDate, endingYearDate, magicWeight);

        if (magicDates.Count > 0)
        {
            foreach (var item in magicDates)
            {
                Console.WriteLine(item.ToString("dd-MM-yyyy"));
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static List<DateTime> GetMagicDates(DateTime startingYear, DateTime endingYear, int weight)
    {
        int sum = 0;
        List<DateTime> results = new List<DateTime>();

        while (endingYear != startingYear)
        {
            sum = 0;
            List<int> digitsArray = DateTimeToDigitsArray(startingYear);
            for (int i = 0; i < digitsArray.Count; i++)
            {
                for (int j = i + 1; j < digitsArray.Count; j++)
                {
                    sum += digitsArray[i] * digitsArray[j];
                }
            }

            if (sum == weight)
            {
                results.Add(startingYear);
            }

            startingYear = startingYear.AddDays(1.0);
        }

        return results;
    }

    private static List<int> DateTimeToDigitsArray(DateTime date)
    {
        int parsedDate = int.Parse(date.ToString("ddMMyyyy"));
        List<int> parsedDateArray = new List<int>();

        while (parsedDate != 0)
        {
            parsedDateArray.Add(parsedDate % 10);
            parsedDate /= 10;
        }

        parsedDateArray.Reverse();

        return parsedDateArray;
    }
}