using System;

public class Volleyball
{
    public static void Main()
    {
        string typeOfYear = Console.ReadLine();
        double numberOfHolidays = double.Parse(Console.ReadLine());
        double numberOfWeekendsInHometown = double.Parse(Console.ReadLine());

        double playsInHometown = numberOfWeekendsInHometown;
        double playsInNormalWeekends = (48.0 - numberOfWeekendsInHometown) * (3.0 / 4.0);
        double playsInHolidays = numberOfHolidays * (2.0 / 3.0);
        double totalPlays = playsInHolidays + playsInHometown + playsInNormalWeekends;
        
        if (typeOfYear == "leap")
        {
            totalPlays *= 1.15;
        }

        Console.WriteLine((int)totalPlays);
    }
}