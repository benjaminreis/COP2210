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

            Console.Write($"\nElection day for {ElectionDate.getYear()} is day: {ElectionDate.getDay()} of the month:  {ElectionDate.getMonth()}");


            Construction();
        }


        internal void Construction()
        {
            var StartDate = GetDate("Start");
            var EndDate = GetDate("End");

            
            var speedDater = new Assignment8.SpeedDating();

            var HalfwayDate = speedDater.getHalfwayDate(StartDate, EndDate);

            Console.Write("\nWelcome to Construction! Where we take two dates and find the halfway point between them");
            Console.Write($"\nThe Halfway Date is:  {HalfwayDate.getMonth()}/{HalfwayDate.getDay()}/{HalfwayDate.getYear()}");
        }



        private Date GetDate(string StartEnd)
        {
            Console.WriteLine($"Please Enter the {StartEnd} Date:");
            var nYear = GetYear();
            var nMonth = GetMonth();
            var nDay = GetDay(nYear, nMonth);

            return new Date(nMonth, nDay, nYear);

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

        private int GetMonth()
        {
            int nMonth = 0;
            do
            {

                Console.WriteLine($"Enter a Month:  (in form of a number 1 = january, 7 = July, 11 = November, etc)");

                string sYear = Console.ReadLine();

                if (!int.TryParse(sYear, out nMonth))
                {
                    Console.WriteLine("Check your format, enter an integer;  1, 2, 3, 5, 8, etc..");
                }

            } while (nMonth < 0);

            return nMonth;
        }

        private int GetDay(int nYear, int nMonth)
        {
            int nDay = 0;

            do
            {
                Console.WriteLine($"Enter a Day:  (in form of a number 1, 2, .. 30");

                string sDay = Console.ReadLine();

                if (!int.TryParse(sDay, out nDay))
                {
                    Console.WriteLine("Check your format, enter an integer;  1, 2, 3, 5, 8, etc..");
                }
                else
                {
                    if (!ValidateMonthDay(nYear, nMonth, nDay))
                    {
                        Console.WriteLine("Date not valid for the given Year and Month, enter another.");
                        nDay = -1;
                    }

                }



            } while (nDay < 0);

            return nDay;

        }

        private bool ValidateMonthDay(int nYear, int nMonth, int nDay)
        {
            var speedDater = new Assignment8.SpeedDating();
            bool IsValid = false;

            switch (nMonth)
            {
                case 2:

                    int FebMaxDays = speedDater.IsLeapYear(nYear) ? 29 : 28;
                    if (nDay <= FebMaxDays && nDay > 0)
                        return true;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (nDay <= 30 && nDay > 0)
                        return true;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (nDay <= 31 && nDay > 0)
                        return true;
                    break;

             }

            return IsValid;
        }





    }
}
