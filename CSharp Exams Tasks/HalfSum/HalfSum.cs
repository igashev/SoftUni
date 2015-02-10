using System;

public class HalfSum
{
    public static void Main()
    {
        int countOfNumbers = int.Parse(Console.ReadLine());

        int[] numbers = new int[2 * countOfNumbers];
        int firstHalfOfNumbers = 0;
        int secondHalfOfNumbers = 0;

        for (int i = 0; i < 2 * countOfNumbers; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i < numbers.Length / 2)
            {
                firstHalfOfNumbers += numbers[i];
            }
            else
            {
                secondHalfOfNumbers += numbers[i];
            }
        }

        if (firstHalfOfNumbers == secondHalfOfNumbers)
        {
            Console.WriteLine("Yes, sum=" + firstHalfOfNumbers);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(firstHalfOfNumbers - secondHalfOfNumbers));
        }
    }
}
