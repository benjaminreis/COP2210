using System;

namespace COP2210
{
    class Program
    {
        static void Main(string[] args)
        {

            int assignment = GetUserInput();


            switch (assignment)
            {
            case (1):


                break;



            case (2):
                    var balloonManager = new Assignment2.BallonManager();

                    balloonManager.Assignment();

                    break;


            case (3):
                    var BottledWaterManager = new Assignment3.BottledWaterManager();
                    BottledWaterManager.Assignment();
                break;

            default:

                    Console.WriteLine("You chose an integer that was not valid!");


                break;
            }
        }

        private static int GetUserInput()
        {
            int choice = new int();
            while (choice <= 0)
            {
                Console.WriteLine("Which Assignment Do you want to run?");

                string assignment = Console.ReadLine();


                if (!int.TryParse(assignment, out choice))
                {
                    Console.WriteLine("You entered an invalid input, please enter an assignment number:  1, 2, 3...");
                }

            }
            return choice;


        }
    }
}
