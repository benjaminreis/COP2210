using System;
using System.Collections.Generic;
using System.Linq;

namespace COP2210.Assignment4
{
    internal class ElapsedTimeCalculatorManager : IManager
    {
        internal ElapsedTimeCalculatorManager()
        {
        }

         void IManager.Assignment()
        {
            //TODO BEN put test cases here...




            bool KeepAsking = true;

            ElapsedTimeCalculator elapsedTimeCalculator = null;

            do
            {
                elapsedTimeCalculator = GetUserInput(elapsedTimeCalculator);

                DisplayResults(elapsedTimeCalculator);

                Console.WriteLine("Do you want to update the End Times and Start Time?  (y/n?)");
                var UpdateRespone = Console.ReadLine();

                if (!IsTrue(UpdateRespone))
                {
                    KeepAsking = true;

                }



            }

            while (KeepAsking);

        }

        private Assignment4.ElapsedTimeCalculator GetUserInput(ElapsedTimeCalculator elapsedTimeCalculator)
        {
            Console.WriteLine("What is the Start Time in HHmm format? eg 1530. ");

            string StartTimeString = Console.ReadLine();

            Console.WriteLine("What is the End Time in HHmm format? eg 1845. ");

            string EndTimeString = Console.ReadLine();

            if (elapsedTimeCalculator == null)
            {
                elapsedTimeCalculator = new ElapsedTimeCalculator(int.Parse(StartTimeString), int.Parse(EndTimeString));
            }
            else
            {
                elapsedTimeCalculator.EndTime = int.Parse(StartTimeString);
                elapsedTimeCalculator.StartTime = int.Parse(EndTimeString);
            }

            return elapsedTimeCalculator;

        }

        private void DisplayResults(Assignment4.ElapsedTimeCalculator elapsedTimeCalculator)
        {
            Console.WriteLine($"Elapsed Time Hour Portion: {elapsedTimeCalculator.HourPortionElapsedTime()}");
            Console.WriteLine($"Elapsed Time Minute Portion: {elapsedTimeCalculator.MinutePortionElapsedTime()}");

            Console.WriteLine($"Total Elapsed Time Minutes: {elapsedTimeCalculator.TotalElapsedTimeMinutes()}");
            Console.WriteLine($"Total Elapsed Time Minutes: {elapsedTimeCalculator.TotalElapsedTimeSeconds()}");
        }

        private bool IsTrue(string UserInput)
         {
            List<string> listTrues = new List<string> { "true", "1", "yes", "ja", "y" };

            return listTrues.Contains(UserInput, StringComparer.OrdinalIgnoreCase) ? true : false;
        }



    }
}
