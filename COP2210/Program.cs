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
                    IManager balloonManager = new Assignment2.BallonManager();

                    balloonManager.Assignment();

                    break;


            case (3):
                    IManager BottledWaterManager = new COP2210.Assignment3.BottledWaterManager();
                    BottledWaterManager.Assignment();
                break;
                
            case (4):
                    IManager ElapsedTimeCalculatorManager = new COP2210.Assignment4.ElapsedTimeCalculatorManager();
                    ElapsedTimeCalculatorManager.Assignment();
                    break;

                case (5):
                    IManager CommissionCalculatorManager = new COP2210.Assignment5.CommissionCalculatorManager();
                    CommissionCalculatorManager.Assignment();
                    break;
                case (6):
                    IManager TriangleAnalyzerManager = new COP2210.Assignment6.TriangleAnalyzerManager();
                    TriangleAnalyzerManager.Assignment();
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
                Console.WriteLine("Which Assignment Do you want to run? 1, 2, 3, 4, 5, 6..");

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
