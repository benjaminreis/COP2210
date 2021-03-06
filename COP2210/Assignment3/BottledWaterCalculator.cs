﻿using System;
namespace COP2210.Assignment3
{
    internal class BottledWaterCalculator
    {
        internal BottledWaterCalculator(string CountryName, int CountryPopulation,
                                      double AverageBottleLength, double AverageBottleVolume)
        {
            this._CountryName = CountryName;
            this._CountryPopulation = CountryPopulation;
            this._AverageBottleLength = AverageBottleLength;
            this._AverageBottleVolume = AverageBottleVolume;
        }
        internal BottledWaterCalculator()
        {
        }

        private string _CountryName;
        private int _CountryPopulation;
        private double _NumberTimesCircleEarth = 190;
        private double _AverageBottleLength;   //  Inches
        private double _AverageBottleVolume;  //Fl ounces
        private int CircumferenceOfEarth = 24902;

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


        internal double NumberOfBottlesUsed()
        {
            double oNumberOfBottles = new double();

            oNumberOfBottles = (_NumberTimesCircleEarth * CircumferenceOfEarth) / this._AverageBottleLength;

            return oNumberOfBottles;
        }


        internal double AverageWaterPerPerson()
        {
            double oAverageWaterPerPerson = new double();
            oAverageWaterPerPerson = (this._AverageBottleVolume * NumberOfBottlesUsed()) / this.CountryPopulation;
            return oAverageWaterPerPerson;
        }

    }
}
