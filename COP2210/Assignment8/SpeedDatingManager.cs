using System;
namespace COP2210.Assignment8
{
    internal class SpeedDatingManager : IManager
    {
        internal SpeedDatingManager()
        {
        }

        void IManager.Assignment()
        {

            var speedDater = new Assignment8.SpeedDating();

            speedDater.auldLangSynch(GetYear());

            var ElectionDate = speedDater.pollDancer(GetYear());

            Console.Write($"Election day for {ElectionDate.getYear()} is day: {ElectionDate.getDay()} of the month:  {ElectionDate.getMonth()}");

        }


        internal void Construction()
        {
            //1.  Call a method to get start date (year, day, month)
            //2.  Call a method to get estimated Completion Date.
            //3.  Check dates to make sure start date is before completion date.  (re-ask if there are issues)
            //4.  Call GetHalfwayDate to find the date halfway.
            //5.  Log the halfwaydate in the Construction Method
        }

        private int GetYear()
        {
            int Year = 0;
            do
            {

                Console.WriteLine($"Enter a year:  (in form of a number 4 digit number NNNN)");

                string sYear = Console.ReadLine();

                if (!int.TryParse(sYear, out Year))
                {
                    Console.WriteLine("Check your format, enter an integer;  1924, 1967, 1984, 2012... etc.");
                }

            } while (Year < 0);

            return Year;
        }


    }
}
