using System;
namespace COP2210.Assignment5
{
    internal class CommissionCalculator
    {
        internal CommissionCalculator(string SalesPersonsName, decimal TotalMonthlySales, int YearsService, string Rank)
        {
            this.SalesPersonsName = SalesPersonsName;
            this.TotalMonthlySales = TotalMonthlySales;
            this.YearsService = YearsService;
            this.Rank = Rank;

        }


        internal string SalesPersonsName;
        internal decimal TotalMonthlySales;
        internal int YearsService;
        internal string Rank;  //“1” = Apprentice, “2” = Junior and “3” = Senior.

        internal string getData()
        {


            return "";
        }

        internal double computerCommission()
        {
            return 0.0;
        }


    }
}
