namespace OddAndEvenJumps
{
    using System;
    using System.Collections.Generic;

    public class OddAndEvenJumps
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower().Replace(" ", string.Empty);
            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());

            List<char> oddLetters = new List<char>();
            List<char> evenLetters = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddLetters.Add(input[i]);
                }
                else
                {
                    evenLetters.Add(input[i]);
                }
            }

            ulong oddLettersResult = CalculateLetters(oddLetters, oddJump);
            ulong evenLettersResult = CalculateLetters(evenLetters, evenJump);

            Console.WriteLine("Odd: {0:X}", oddLettersResult);
            Console.WriteLine("Even: {0:X}", evenLettersResult);
        }

        private static ulong CalculateLetters(List<char> letters, int jumps)
        {
            ulong result = 0;

            for (int i = 0; i < letters.Count; i++)
            {
                if ((i + 1) % jumps == 0)
                {
                    result *= letters[i];
                }
                else
                {
                    result += letters[i];
                }
            }
            return result;
        }
    }
}
