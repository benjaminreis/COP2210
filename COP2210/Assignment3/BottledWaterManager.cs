using System;
namespace COP2210.Assignment3
{
    internal class BottledWaterManager : IManager
    {
        internal BottledWaterManager()
        {
        }


        void IManager.Assignment()
        {
            var BottledWaterCalculator = new Assignment3.BottledWaterCalculator("USA", 350000000, 8.5, 16.9);


            Console.WriteLine($"Average Bottle Length: {BottledWaterCalculator.AverageBottleLength}");
            Console.WriteLine($"Average Bottle Volume: {BottledWaterCalculator.AverageBottleVolume}");
            Console.WriteLine($"Country Name: {BottledWaterCalculator.CountryName}");
            Console.WriteLine($"Number of times circle earth: {BottledWaterCalculator.NumberTimesCircleEarth}");
            Console.WriteLine($"Country Population: {BottledWaterCalculator.CountryPopulation}");

            Console.WriteLine($"Avereage Water Per person: {Math.Round(BottledWaterCalculator.AverageWaterPerPerson(), 3)}");
            Console.WriteLine($"Number of Bottles Used: {Math.Round(BottledWaterCalculator.NumberOfBottlesUsed(), 3)}");


            BottledWaterCalculator.AverageBottleLength = 9.1;
            BottledWaterCalculator.AverageBottleVolume = 17.2;

            Console.WriteLine($"Average Bottle Length: {BottledWaterCalculator.AverageBottleLength}");
            Console.WriteLine($"Average Bottle Volume: {BottledWaterCalculator.AverageBottleVolume}");
            Console.WriteLine($"Avereage Water Per person: {Math.Round(BottledWaterCalculator.AverageWaterPerPerson(), 3)}");
            Console.WriteLine($"Number of Bottles Used: {Math.Round(BottledWaterCalculator.NumberOfBottlesUsed(), 3)}");
        }
    }
}
