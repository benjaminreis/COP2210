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
            throw new NotImplementedException();
        }


        private Assignment5.CommissionCalculator GetUserInput()
        {
            Console.WriteLine("What is the SalesPersons name?");

            string SalesPersonName = Console.ReadLine();

            Console.WriteLine("What is the SalesPersons Monthly Sales?");

            string MonthlySales = Console.ReadLine();

            Console.WriteLine("What is the SalesPersons years of Service?");

            string YearsOfService = Console.ReadLine();

            Console.WriteLine("What is the SalesPersons rank? (example:  1 = Apprentice; 2 = Junior; 3 = Senior. ");

            string SalesPersonsRank = Console.ReadLine();






        }
    }
}
