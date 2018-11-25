using System;
namespace COP2210.Assignment5
{
    internal class CommissionCalculatorManager : IManager
    {
        internal CommissionCalculatorManager()
        {
        }

        void IManager.Assignment()
        {

            CommissionCalculator commissionCalculator = GetUserInput();

            var tempCommission = commissionCalculator.ComputeCommission();

            commissionCalculator.GetData();

        }


        private Assignment5.CommissionCalculator GetUserInput()
        {
            Console.WriteLine("What is the SalesPersons name?");

            string SalesPersonName = Console.ReadLine();

            var MonthlySales = GetMonthlySales();

            var YearsService = GetYearsService();

            var Rank = GetSalesPersonRank();



            CommissionCalculator commissionCalculator = new CommissionCalculator(SalesPersonName, MonthlySales, YearsService, Rank);

            return commissionCalculator;
   


        }

        private int GetSalesPersonRank()
        {
            int rank;
            do
            {
                Console.WriteLine("What is the SalesPersons rank? (example:  1 = Apprentice; 2 = Junior; 3 = Senior. ");

                string SalesPersonsRank = Console.ReadLine();


                if (!int.TryParse(SalesPersonsRank, out rank))
                {
                    Console.WriteLine("Check your input format: needs to be 1, 2, 3..");
                }
            } while (rank < 0);

            return rank;

        }

        private int GetYearsService()
        {
            int yearsService;

            do
            {
                Console.WriteLine("What is the SalesPersons years of Service?");

                string YearsOfService = Console.ReadLine();

                if (!int.TryParse(YearsOfService, out yearsService))
                {
                    Console.WriteLine("Check your input format, needs to be a number: 1, 2, 5, 10, etc...");
                }


            } while (yearsService < 1);
            return yearsService;
        }


        private double GetMonthlySales()

        {
            double MonthlySales;

            do
            {

                Console.WriteLine("What is the SalesPersons Monthly Sales?");

                string sMonthlySales = Console.ReadLine();

                if (!double.TryParse(sMonthlySales, out MonthlySales))
                {
                    MonthlySales = -1;
                }


            } while (MonthlySales <0);  //TODO BEN may revist, this could cause a bug down the line..  
                                        //TODO What if they credit back sales and legitimately go negative?  possibly use a boolean to track the success..
            return MonthlySales;
        }

    }
}
