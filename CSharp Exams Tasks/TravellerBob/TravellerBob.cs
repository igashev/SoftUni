using System;

class TravellerBob
{
    static void Main()
    {
        const int ContractTravelsPerMonth = 4 * 3;
        const int FamilyTravelPerMonth = 2 * 2;

        string kindOfYear = Console.ReadLine();
        int numberOfContractMonths = int.Parse(Console.ReadLine());
        int numberOfFamilyMonths = int.Parse(Console.ReadLine());

        int monthsLeft = 12 - (numberOfContractMonths + numberOfFamilyMonths);
        int totalContractTravels = numberOfContractMonths * ContractTravelsPerMonth;
        int totalFamilyTravels = numberOfFamilyMonths * FamilyTravelPerMonth;
        double totalNormalTravels = monthsLeft * ContractTravelsPerMonth * 0.6;
        double totalTravels = totalContractTravels + totalFamilyTravels + totalNormalTravels;

        if (kindOfYear == "leap")
        {
            totalTravels += totalTravels * 0.05;
        }

        Console.WriteLine((int)totalTravels);
    }
}