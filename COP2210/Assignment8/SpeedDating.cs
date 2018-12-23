using System;
namespace COP2210.Assignment8
{

    /**
     * A class to give students experience using loops.  This class
     * creates and manipulates objects of Greg's Date class.
     */
    internal class SpeedDating
    {
        // Note: this class has no instance variables!

        /**
         * Create a SpeedDating object
         */
        public SpeedDating()
        { }
        // Note to students: Constructor takes no parameters - this is known
        // as a "default" constructor.  This one also has an empty body

        /**
         * Computes and prints the day of the week on which New Year's Day will
         * fall for 10 consecutive years
         * @param theYear the first of the 10 consecutive years
         */
        public void auldLangSynch(int theYear)
        {
            for (int i = theYear; i < theYear + 10; i++)
            {
                var Date = new COP2210.Assignment8.Date(1, 1, i);
                var dayOfWeek = Date.getDayOfWeek();

                Console.Write($"{i.ToString()}: {dayOfWeek}\n");
            }
         }

        /**
         * Computes and returns the Date on which Election Day will fall 
         * in the USA for a given year
         *
         * NOTE: By law, Election Day is the first Tuesday after the first
         * Monday in November
         *
         * @param year the year for which to compute the date of Election Day
         * @return the Date of Election Day for the specified year
         */
        internal Date pollDancer(int year)
        {
            var dayOfMonth = 1;
            var IsElectionDay = false;
            var MondayPassed = false;
            while (!IsElectionDay)
            {
                var tempDate = new Date(11, dayOfMonth, year);
                if (tempDate.getDayOfWeek() == "Monday")
                {
                    MondayPassed = true;
                }

                if ((tempDate.getDayOfWeek() != "Tuesday") || MondayPassed == false)
                {
                    dayOfMonth++;

                }
                else
                {
                    IsElectionDay = true;
                    return tempDate;
                }
            }
                   return new Date(1, 1, 1582);
        }

        /**
         * Computes and returns the Date that occurs "half way" between two Dates.
         * 
         * @param startDate the earlier of the two Dates
         * @param endDate the later of the two Dates
         * @return the Date midway between startDate and endDate 
         */
        internal Date getHalfwayDate(Date StartDate, Date EndDate)
        {
            // TO DO: write remainder of body of this method here
            var StartEpoch = DaysSinceEpoch(StartDate);
            var EndEpoch = DaysSinceEpoch(EndDate);
            var halfwayEpoch = (StartEpoch + EndEpoch) / 2;
            int halfwayYear = (halfwayEpoch / 365) + 1582;
            int halfwayDaysYear = halfwayEpoch % 365;
            int halfDayOfMonth = 0;
            int halfwayMonth = 0;

            if (halfwayDaysYear > 334)
            {
                halfDayOfMonth = halfwayDaysYear - 334;
                halfwayMonth = 12;
            }
            else if (halfwayDaysYear > 304)
            {
                halfDayOfMonth = halfwayDaysYear - 304;
                halfwayMonth = 11;
            }
            else if (halfwayDaysYear > 273)
            {
                halfDayOfMonth = halfwayDaysYear - 273;
                halfwayMonth = 10;
            }
            else if (halfwayDaysYear > 243)
            {
                halfDayOfMonth = halfwayDaysYear - 243;
                halfwayMonth = 9;
            }
            else if (halfwayDaysYear > 212)
            {
                halfDayOfMonth = halfwayDaysYear - 212;
                halfwayMonth = 8;
            }
            else if (halfwayDaysYear > 181)
            {
                halfDayOfMonth = halfwayDaysYear - 181;
                halfwayMonth = 7;
            }
            else if (halfwayDaysYear > 151)
            {
                halfDayOfMonth = halfwayDaysYear - 151;
                halfwayMonth = 6;
            }
            else if (halfwayDaysYear > 120)
            {
                halfDayOfMonth = halfwayDaysYear - 120;
                halfwayMonth = 5;
            }
            else if (halfwayDaysYear > 90)
            {
                halfDayOfMonth = halfwayDaysYear - 90;
                halfwayMonth = 4;
            }
            else if (halfwayDaysYear > 59)
            {
                halfDayOfMonth = halfwayDaysYear - 59;
                halfwayMonth = 3;
            }
            else if (halfwayDaysYear > 31)
            {
                halfDayOfMonth = halfwayDaysYear - 31;
                halfwayMonth = 2;
            }
            else
            {
                halfDayOfMonth = halfwayDaysYear;
                halfwayMonth = 1;
            }


            // bogus return value so class skeleton will compile and execute
            return new Date(halfwayMonth, halfDayOfMonth, halfwayYear);
        }


        //1/1/1582 is Epoch
        private int DaysSinceEpoch(Date Date)
        {
            int nDaysSinceEpoch = 0;


            nDaysSinceEpoch = Date.getDay();


            switch (Date.getMonth())
            {

                case 1:
                    break;
                case 2:
                    nDaysSinceEpoch += 31;
                    break;
                case 3:
                    nDaysSinceEpoch += 59;
                    break;
                case 4:
                    nDaysSinceEpoch += 90;
                    break;
                case 5:
                    nDaysSinceEpoch += 120;
                    break;
                case 6:
                    nDaysSinceEpoch += 151;
                    break;
                case 7:
                    nDaysSinceEpoch += 181;
                    break;
                case 8:
                    nDaysSinceEpoch += 212;
                    break;
                case 9:
                    nDaysSinceEpoch += 243;
                    break;
                case 10:
                    nDaysSinceEpoch += 273;
                    break;
                case 11:
                    nDaysSinceEpoch += 304;
                    break;
                case 12:
                    nDaysSinceEpoch += 334;
                    break;
            }
            if (IsLeapYear(Date.getYear()))
            {
                nDaysSinceEpoch += 1;
            }

            var years = Date.getYear() - 1582;
            nDaysSinceEpoch += (years * 365);  //Not accounting for leap years...


            return nDaysSinceEpoch;
        }

        internal bool IsLeapYear(int Year)
        {
            if (Year % 100 == 0 && Year % 400 == 0)
            {
                return true;
            }

            if (Year % 100 == 0)
            {
                return false;  //IF its divisible by 100 but not divisible by 400, its not a leap year

            }
            if (Year % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
