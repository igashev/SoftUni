using System;

public class SumOfElements
{
    public static void Main()
    {
        string[] inputNumbers = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);

        Array.Sort(numbers);

        int highestNumber = numbers[numbers.Length - 1];
        int sumOfOtherNumbers = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            sumOfOtherNumbers += numbers[i];
        }

        if (highestNumber == sumOfOtherNumbers)
        {
            Console.WriteLine("Yes, sum=" + highestNumber);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(highestNumber - sumOfOtherNumbers));
        }
    }
}