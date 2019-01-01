using System;
namespace COP2210.Assignment9
{
    internal class CertificateOfDeposit
    {
        internal CertificateOfDeposit(decimal Principal, decimal InterestRate, int Maturity, CompoundingMode CompoundingFrequency)
        {
            this._Principal = Principal;
            this._InterestRate = InterestRate;
            this._Maturity = Maturity;
            this._CompoundingFrequency = (int)CompoundingFrequency;
        }


        private decimal _Principal;
        private decimal _InterestRate;
        private int _Maturity;
        private int _CompoundingFrequency;  //times compounding per year.  Quartery = 4

        internal enum CompoundingMode : int { Quarterly = 4, Monthly = 12, Daily = 365 };


        internal decimal ComputeAccumulatedValue(int Year)
        {
            //TODO BEN write method to Compute value of loan through a given year from now.  
            //this will computer principal plus accumulated interest

            var val = this._Principal * (1 + (this._InterestRate / this._CompoundingFrequency));
            var interest = Math.Pow((double)val, (this._CompoundingFrequency * (DateTime.Now.Year - Year)));
            return 0.0M;
        }
    }
}
