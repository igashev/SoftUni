using System;

public class OddEvenSum
{
    public static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());
        int[] numbers = new int[countOfNumbers * 2];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sumOfEvenNumbers = 0;
        int sumOfOddNumbers = 0;
        bool isOdd = true;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (isOdd)
            {
                sumOfOddNumbers += numbers[i];
            }
            else
            {
                sumOfEvenNumbers += numbers[i];
            }

            isOdd = !isOdd;
        }

        if (sumOfEvenNumbers == sumOfOddNumbers)
        {
            Console.WriteLine("Yes, sum=" + sumOfEvenNumbers);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(sumOfEvenNumbers - sumOfOddNumbers));
        }
    }
}