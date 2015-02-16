using System;

public class WorkHours
{
    public static void Main()
    {
        int requeredHours = int.Parse(Console.ReadLine());
        int daysAvailable = int.Parse(Console.ReadLine());
        int productivityPercentage = int.Parse(Console.ReadLine());

        int bikingPercentage = 10;
        double hoursAvailable = (daysAvailable - (daysAvailable * (bikingPercentage / 100.0))) * 12;
        double efficientWorkHours = Math.Floor(hoursAvailable * (productivityPercentage / 100.0));
        int result = (int)efficientWorkHours - requeredHours;

        if (result < 0)
        {
            Console.WriteLine("{0}\n{1}", "No", result);
        }
        else
        {
            Console.WriteLine("{0}\n{1}", "Yes", result);
        }
    }
}