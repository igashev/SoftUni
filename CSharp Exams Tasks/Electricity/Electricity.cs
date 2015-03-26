namespace Electricity
{
    using System;

    public class Electricity
    {
        public static void Main()
        {
            int numberOfFloors = int.Parse(Console.ReadLine());
            int numberOfFlats = int.Parse(Console.ReadLine());
            DateTime timeOfTheDay = DateTime.Parse(Console.ReadLine());

            double totalFlats = numberOfFlats * numberOfFloors;

            bool isInFirstTimespan = DateTime.Parse("14:00") <= timeOfTheDay && timeOfTheDay <= DateTime.Parse("18:59");
            bool isInSecondTimespan = DateTime.Parse("19:00") <= timeOfTheDay && timeOfTheDay <= DateTime.Parse("23:59");
            bool isInThirdTimespan = DateTime.Parse("00:00") <= timeOfTheDay && timeOfTheDay <= DateTime.Parse("08:59");

            uint totalConsumption = 0;

            if (isInFirstTimespan)
            {
                totalConsumption = (uint)(CalculateConsuption(2, 2) * totalFlats);
            }
            else if (isInSecondTimespan)
            {
                totalConsumption = (uint)(CalculateConsuption(7, 6) * totalFlats);
            }
            else if (isInThirdTimespan)
            {
                totalConsumption = (uint)(CalculateConsuption(1, 8) * totalFlats);
            }

            Console.WriteLine("{0} Watts", totalConsumption);
        }

        private static double CalculateConsuption(int lamps, int computers)
        {
            double lapmConsumtion = 100.53;
            double computerConsumtion = 125.9;

            double totalLampConsumtion = lamps * lapmConsumtion;
            double totalComputerConsumtion = computers * computerConsumtion;

            double totalConsumption = totalLampConsumtion + totalComputerConsumtion;

            return totalConsumption;
        }
    }
}
