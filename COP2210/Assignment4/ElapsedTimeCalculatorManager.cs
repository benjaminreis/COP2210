using System;
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



            //var ElapsedTime = new Assignment4.ElapsedTimeCalculator(1500, 1630);

            //var x = ElapsedTime.HourPortionElapsedTime();
            //var y = ElapsedTime.MinutePortionElapsedTime();

            //var t = ElapsedTime.TotalElapsedTimeMinutes();
            //var u = ElapsedTime.TotalElapsedTimeSeconds();
            bool KeepAsking = true;

            ElapsedTimeCalculator elapsedTimeCalculator = null;

            do
            {
                GetUserInput(elapsedTimeCalculator);

                Console.WriteLine("Do you want to update the End Times and Start Time?  (y/n?)");
                var UpdateRespone = Console.ReadLine(); 

               if (!bool.TryParse(UpdateRespone, out KeepAsking)
                {
                    KeepAsking = true;

                    //TODO BEN implement "ISTrue" from below, right now it onky validated for 1's and 0's
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
                elapsedTimeCalculator = new ElapsedTimeCalculator(int.Parse(StartTimeString), int.Parse(EndTimeString))
            }
            else
            {
                elapsedTimeCalculator.EndTime = int.Parse(StartTimeString);
                elapsedTimeCalculator.StartTime = int.Parse(EndTimeString);
            }

            return elapsedTimeCalculator;

        }

         private bool IsTrue(string UserInput)
         {
                    //TODO BEN implement this to read the boolean response from user.
            return true;
         }



    }
}
