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

        public string CountryName { 
            get 
            { 
                return _CountryName; 
            } 
            set 
            { 
                _CountryName = value;
            } 
        }

        public int CountryPopulation
        {
            get
            {
                return _CountryPopulation;
            }
            set
            {
                _CountryPopulation = value;
            }
        }


        public double NumberTimesCircleEarth
        {
            get
            {
                return _NumberTimesCircleEarth;
            }
            set
            {
                _NumberTimesCircleEarth = value;
            }
        }

        public double AverageBottleLength
        {
            get
            {
                return _AverageBottleLength;
            }
            set
            {
                _AverageBottleLength = value;
            }
        }

        public double AverageBottleVolume
        {
            get
            {
                return _AverageBottleVolume;
            }
            set
            {
                _AverageBottleVolume = value;
            }
        }


        internal double NumberOfBottlesUsed(double AverageBottleLength, double NumberTimesCircleEarth)
        {
            double NumberOfBottles = new double();

            NumberOfBottles = NumberTimesCircleEarth / AverageBottleLength;

            return NumberOfBottles;
        }


        internal double AverageWaterPerPerson()
        {
            double AverageWaterPerPerson = new double();

            return AverageWaterPerPerson;
        }

    }
}
