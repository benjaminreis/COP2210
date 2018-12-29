using System;
namespace COP2210.Assignment9
{
    internal class CertificateOfDeposit
    {
        internal CertificateOfDeposit()
        {
        }


        private decimal Principal;
        private decimal InterestRate;
        private int Maturity;
        private CompoundingMode CompoundingFrequency;  //times compounding per year.  Quartery = 4

        enum CompoundingMode : int { Quarterly = 4, Monthly = 12, Daily = 365 };


        internal decimal ComputeAccumulatedValue(int Year)
        {
            //TODO BEN write method to Compute value of loan through a given year from now.  
            //this will computer principal plus accumulated interest

            var interest = Principal * 
            return 0.0M;
        }
    }
}
