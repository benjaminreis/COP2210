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
        public Date pollDancer(int year)
        {
            // TO DO: write body of method here

            //Election Day is fixed by law as the first Tuesday after the first Monday in November. 
            //Have the user enter another year, call the pollDancer method, 
            //and print the Date object returned, properly labeled. 
            //Print the Date in your main method, not in pollDancer

            //TODO BEN idea:  call the date function and pass the year and the month until you find first monday in november?
            //THis is less that efficient

            // bogus return value so class skeleton will compile and execute
            return null;
        }

        /**
         * Computes and returns the Date that occurs "half way" between two Dates.
         * 
         * @param startDate the earlier of the two Dates
         * @param endDate the later of the two Dates
         * @return the Date midway between startDate and endDate 
         */
        public Date getHalfwayDate(Date startDate, Date endDate)
        {
            // TO DO: write remainder of body of this method here

            // bogus return value so class skeleton will compile and execute
            return null;
        }
    }
}
