using System;

public class NineDigitMagicNumbers
{
    private static void Main()
    {
        const int MinValueOfNumber = 111;
        const int MaxValueOfNumber = 777;

        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int resultsCount = 0;

        for (int firstNumber = MinValueOfNumber; firstNumber <= MaxValueOfNumber; firstNumber++)
        {
            int secondNumber = firstNumber + diff;
            int thirdNumber = secondNumber + diff;

            if (IsNumberAllowed(firstNumber) && IsNumberAllowed(secondNumber) &&
                IsNumberAllowed(thirdNumber) && thirdNumber <= 777 &&
                SumDigits(firstNumber) + SumDigits(secondNumber) + SumDigits(thirdNumber) == sum)
            {
                Console.WriteLine("{0}{1}{2}", firstNumber, secondNumber, thirdNumber);

                resultsCount++;
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static bool IsNumberAllowed(int number)
    {
        string numberIntoString = number.ToString();

        foreach (var digit in numberIntoString)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }

        return true;
    }

    private static int SumDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}