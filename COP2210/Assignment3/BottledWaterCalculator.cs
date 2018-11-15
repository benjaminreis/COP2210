using System;
namespace COP2210.Assignment3
{
    public class BottledWaterCalculator
    {
        public BottledWaterCalculator(string CountryName, int CountryPopulation, double NumberTimesCircleEarth, 
                                      double AverageBottleLength, double AverageBottleVolume)
        {
            this._CountryName = CountryName;
            this._CountryPopulation = CountryPopulation;
            this._AverageBottleLength = AverageBottleLength;
            this._AverageBottleVolume = AverageBottleVolume;
            this._NumberTimesCircleEarth = NumberTimesCircleEarth;
        }


        private string _CountryName;
        private int _CountryPopulation;
        private double _NumberTimesCircleEarth;
        private double _AverageBottleLength;   //  Inches
        private double _AverageBottleVolume;  //Fl ounces



    }
}
