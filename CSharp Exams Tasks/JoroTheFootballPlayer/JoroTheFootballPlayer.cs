using System;

public class JoroTheFootballPlayer
{
    public static void Main()
    {
        string year = Console.ReadLine();
        double numberOfHolidays = double.Parse(Console.ReadLine());
        double numberOfWeekendsInHometown = double.Parse(Console.ReadLine());

        double playsInNormalWeekends = (2.0 / 3.0) * (52.0 - numberOfWeekendsInHometown);
        double playsInHolidays = (1.0 / 2.0) * numberOfHolidays;
        double totalPlays = 0;
        int playsIfYearIsLeap = 3;

        if (year == "t")
        {
            totalPlays = playsIfYearIsLeap + playsInHolidays + playsInNormalWeekends + numberOfWeekendsInHometown;
        }
        else
        {
            totalPlays = playsInHolidays + playsInNormalWeekends + numberOfWeekendsInHometown;
        }

        Console.WriteLine((int)totalPlays);
    }
}

