using System;
namespace COP2210.Assignment8
{

    /**
     * Creates and manipulates dates on the Gregorian calendar, i.e. any 
     * date since October 15, 1582.  Date objects have a month, day, and year
     *
     * @author Greg
     * Copyright:  Greg Shaw, October 15, 2010
     */
    public class Date
    {
        // instance var's
        private int day;        // 1..number of days in the month
        private int month;      // 1..12
        private int year;       // >= 1582

        // DAY_NAMES[0] is "Sunday", DAY_NAMES[6] is "Saturday"
        private static String[] DAY_NAMES = {"Sunday", "Monday", "Tuesday",
                                "Wednesday","Thursday", "Friday", "Saturday"};

        // MONTH_NAMES[1] is "January", MONTH_NAMES[12] is "December"
        private static String[] MONTH_NAMES = {"", "January", "February",
                         "March", "April", "May", "June","July", "August",
                         "September", "October", "November", "December"};

        // DAYS_IN_MONTH[1] is 31 (January), DAYS_IN_MONTH[12] is 31 (December)
        private static int[] DAYS_IN_MONTH = { 0, 31, 28, 31, 30, 31, 30,
                                                31, 31, 30, 31, 30, 31 };
        // The first date is 10/15/1582 
        private static int FIRST_MONTH = 10;
        private static int FIRST_DAY = 15;
        private static int FIRST_YEAR = 1582;
        private static Date FIRST_DATE = new Date
                                               (FIRST_MONTH, FIRST_DAY, FIRST_YEAR);

        // 10/15/1582 was a Friday
        private static int START_DAY_INDEX = 5;  // DAY_NAMES[5] = "Friday"

        /**
         * Creates a date object
         * @param month the month
         * @param day the day
         * @param year the year
         * @throws DateException on attempt to create invalid date
         */
        public Date(int month, int day, int year)
        {
            // create part of Exception message, in case of illegal date
            String s = month + "/" + day + "/" + year;

            // check for illegal month
            if (month > 12 || month < 1)
            {
                throw new DateException(s + "\nIllegal month: " + month
                        + "  (Month must be between 1 and 12)");
            }

            // check for year < 1582 or date in 1582 but prior to October 15th
            if ((year < 1582)
                    || (year == 1582 && month < 10)
                    || (year == 1582 && month == 10 && day < 15))
            {
                throw new DateException(s
                        + "  (Earliest legal date is October 15, 1582)");
            }

            // check for February 29th and NOT a leap year
            if (month == 2 && day == 29 && !isLeapYear(year))
            {
                throw new DateException(s + "  (" + year + " is not a leap year)");
            }

            // check for all 4 possible illegal day values
            //   1. day is <= 0
            //   2. February of a leap year and day > 29
            //   3. February, NOT a leap year and day > 28
            //   4. day > number of days in the month
            if (day <= 0
                 || month == 2 && isLeapYear(year) && day > 29
                 || month == 2 && !isLeapYear(year) && day > 28
                 || month != 2 && day > DAYS_IN_MONTH[month])
            {
                throw new DateException(s + "\nIllegal day: " + day + "\nFor "
                   + (month == 2 ? "February " + year : MONTH_NAMES[month])
                   + ", must be between 1 and "
                   + (isLeapYear(year) && month == 2 ? 29 : DAYS_IN_MONTH[month]));
            }

            // here if month, day, and year are all good
            this.month = month;
            this.day = day;
            this.year = year;
        }

        /**
         * Returns the day portion of this Date, as an int between 1 and the
         * number of days in the month
         * @return the day
         */
        public int getDay()
        {
            return day;
        }

        /**
         * Returns the month of this Date, as an int between 1 and 12
         * @return the month
         */
        public int getMonth()
        {
            return month;
        }

        /**
         * Returns the year of this Date
         * @return the year
         */
        public int getYear()
        {
            return year;
        }

        /**
         * Returns the month as a String (e.g. "March")
         * @return the name of the month
         */
        private String getMonthName()
        {
            return MONTH_NAMES[month];
        }

        /**
         * Returns the day of the week (e.g. "Saturday")
         * @return the day of the week
         */
        public String getDayOfWeek()
        {
            // start at 1st date
            Date tempDate = new Date(FIRST_MONTH, FIRST_DAY, FIRST_YEAR);

            int dayNameIndex = START_DAY_INDEX;           // 1st was "Friday"

            // repeat until tempDate reaches date method was called for
            while (!tempDate.equals(this))
            {
                tempDate.next();                          // increment tempDate
                dayNameIndex = (dayNameIndex + 1) % 7;    // update day of week
            }
            return DAY_NAMES[dayNameIndex];
        }

        /**
         * Is a specified Date equal to this Date?
         * @param otherDate the Date being tested for equality to this Date
         * @return true if the two dates have the same month, day, and year;
         * false if not
         */
        public bool equals(Object otherDate)
        {
            Date other = (Date)otherDate;
            return this.month == other.month &&
                   this.day == other.day &&
                   this.year == other.year;
        }

        /**
         * Increases this Date by one day.
         * Month and year roll over as necessary.
         */
        public void next()
        {
            if (month == 2 && day == 29)        // if it's February 29th...
            {
                day = 1;                        // ...next day is March 1st
                month = 3;
            }
            else if (month == 2 && day == 28)   // if it's February 28th...
            {
                if (this.isLeapYear())          // if it's a leap year...
                {
                    day = 29;                   // ...next day is Feb 29th
                }
                else                            // not a leap year...
                {
                    day = 1;                    // ...next day is March 1st
                    month = 3;
                }
            }
            else if (day == 30)                 // if it's the 30th...
            {
                if (month == 9 || month == 4 ||    // if it's September, April,
                    month == 6 || month == 11)     // June, or November...
                {
                    day = 1;                       // ...next day is the 1st
                    month++;                       //    of the next month
                }
                else                               // it's a 31-day month...
                {
                    day = 31;                      // ...next day is the 31st
                }
            }
            else if (day == 31)                    // if it's the 31st...
            {
                if (month == 12)                   // ...of December...
                {
                    day = 1;                       // ...Happy New year!
                    month = 1;
                    year++;
                }
                else                                // not December...
                {
                    day = 1;                        // ...next day is 1st day
                    month++;                        //    of next month
                }
            }
            else                                    // not last day of month...
            {
                day++;                  // ...next day, same month&year
            }
        }

        /**
         * Decreases this Date by one day.
         * Month and year roll back as necessary.
         */
        public void previous()
        {
            if (this.equals(FIRST_DATE))  // no previous Gregorian Date
            {
                throw new DateException("Earliest legal date is October 15, 1582");
            }

            if (day != 1)                       // if not the 1st of the month...
            {
                day--;              // ...prev day, same month & year
            }
            else if (month == 1)                // if it's January 1st...
            {
                day = 31;                       // ...previous day is Dec 31st
                month = 12;                     //    of previous year
                year--;
            }
            else if (month == 3)                // if it's March 1st...
            {
                if (this.isLeapYear())          // if it's a leap year...
                {
                    day = 29;                   // ...previous day is Feb 29th
                    month = 2;
                }
                else                            // not a leap year...
                {
                    day = 28;                   // ...previous day is Feb 28th
                    month = 2;
                }
            }
            else                                // the 1st, but not March or Jan...
            {
                if (month == 10 ||              // if previous month has 30 days...
                    month == 5 ||
                    month == 7 ||
                    month == 12)
                {
                    day = 30;                   // ...previous day is the 30th
                    month--;                   //    of the previous month
                }
                else                            // if previous month has 31 days...
                {
                    day = 31;                   // ...previous day is the 31st
                    month--;                    //    of the previous month
                }
            }
        }

        /**
         * Adds a specified number of days to this Date
         * @param days the number of days by which to increase the Date
         * (if negative, Date is decreased by that number)
         */
        public void add(int days)
        {
            if (days < 0)
            {
                this.subtract(-days);
            }
            else
            {
                for (int i = 1; i <= days; i++)
                {
                    this.next();
                }
            }
        }

        /**
         * Subtracts a specified number of days from this Date
         * @param days the number of days by which to decrease the Date
         * (if negative, Date is increased by that number)
         */
        public void subtract(int days)
        {
            if (days < 0)
            {
                this.add(-days);
            }
            else
            {
                for (int i = 1; i <= days; i++)
                {
                    this.previous();
                }
            }
        }

        /**
         * Returns this Date in short format - numbers only
         * @return the Date as "mm/dd/yyyy"
         */
        public String getShortDate()
        {
            String sReturn = "";
            if (month <= 9)       // add leading zero if single digit month
            {
                sReturn += "0";
            }
            sReturn += month + "/";
            if (day <= 9)         // add leading zero if single digit day
            {
                sReturn += "0";
            }
            return sReturn + day + "/" + year;
        }

        /**
         * Returns this Date in medium format - with month name
         * @return the Date as "month day, year"
         * (E.g. October 15, 1582)
         */
        public String getMediumDate()
        {
            return MONTH_NAMES[month] + " " + day + ", " + year;
        }

        /**
         * Returns this Date in long format, with day-of-week,
         * month name, and the ordinal of the day
         * @return the Date as "day-of-week, month day, year"
         * (E.g. "Friday, October 15th, 1582")
         */
        public String getLongDate()
        {
            // start with day of week and month
            String sReturn = this.getDayOfWeek() + ", " + MONTH_NAMES[month]
                         + " " + day;
            // concatenate ordinal of the day
            switch (day)
            {
                case 1:
                    sReturn += "st, ";
                    break;
                case 2:
                    sReturn += "nd, ";
                    break;
                case 3:
                    sReturn += "rd, ";
                    break;
                case 21:
                    sReturn += "st, ";
                    break;
                case 22:
                    sReturn += "nd, ";
                    break;
                case 23:
                    sReturn += "rd, ";
                    break;
                case 31:
                    sReturn += "st, ";
                    break;
                default:
                    sReturn += "th, ";
                    break;
            }
            return sReturn + year;       // concatenate year and return
        }

        // Is this Date in a leap year?
        private bool isLeapYear()
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Is a specified year a leap year?
        private static bool isLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }



internal class DateException : ArithmeticException
    {
        public DateException()
        { 
        }

        public DateException(String message)
        {
        //super(message);
        //TODO BEN figure out how C# calls the base
        }

    }
}
