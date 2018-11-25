using System;
namespace COP2210.Assignment5
{
    internal class CommissionCalculator
    {
        internal CommissionCalculator(string SalesPersonsName, double TotalMonthlySales, int YearsService, int Rank)
        {
            this.SalesPersonsName = SalesPersonsName;
            this.TotalMonthlySales = TotalMonthlySales;
            this.YearsService = YearsService;
            this.Rank = Rank;

        }


        internal string SalesPersonsName;
        internal double TotalMonthlySales;
        internal int YearsService;
        internal int Rank;  //“1” = Apprentice, “2” = Junior and “3” = Senior.

        internal string GetData()
        {

            string outPut = "Employee: " + SalesPersonsName
                + $"%nTotal Monthly Sales: {TotalMonthlySales:C}"
                + $"\n\nRank: {Rank}"
                + $"\n\nYears of Service:  {YearsService}";
            return outPut;
        }

        internal double ComputeCommission()
        {
            return ComputeSalesCommission() + ComputeRankIncentive() + ComputeRetentionCommission();
        }

        private double ComputeRankIncentive()
        {
            var rankPercentage = 0.0;
            switch (this.Rank)
            {
                case 1:
                    rankPercentage = .001;
                    break;

                case 2:
                    rankPercentage = .002;
                    break;
                default:
                    break;
            }

            return TotalMonthlySales * rankPercentage;
        }

        private double ComputeRetentionCommission()
        {
            double rententionPercentage = this.YearsService > 10 ? .01 : (this.YearsService / 100);
            return this.TotalMonthlySales * rententionPercentage;
        }

        private double ComputeSalesCommission()
        {
            var salesAmount = this.TotalMonthlySales;
            var commissionAmount = 0.0;

            if (salesAmount <= 100000.0)
            {
                return commissionAmount;
            } 
            else if (salesAmount <= 200000.0)
            {
                commissionAmount = commissionAmount + (CalcSaleslevel(100000.0, 200000.0, salesAmount) * .01);
            }
            else if (salesAmount <= 300000.0)
            {
                commissionAmount = commissionAmount + (CalcSaleslevel(200000.0, 300000.0, salesAmount) * .015);
            }
            else if (salesAmount <= 400000.0)
            {
                commissionAmount = commissionAmount + (CalcSaleslevel(300000.0, 400000.0, salesAmount) * .0175);
            }
            else 
            {
                commissionAmount = commissionAmount + (salesAmount - 400000.0) * .02;
            }



            return commissionAmount;
        }

        private double CalcSaleslevel(double floor, double ceiling, double TotalSales)
        {
            var calcCommision = 0.0;
            if (TotalSales > floor)
            {
                calcCommision = TotalSales - ceiling;
            }
            calcCommision = calcCommision - floor;

            return calcCommision;
        }
    }
}
