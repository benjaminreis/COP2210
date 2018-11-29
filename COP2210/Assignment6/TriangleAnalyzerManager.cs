using System;
namespace COP2210.Assignment6
{
    internal class TriangleAnalyzerManager : IManager
    {
        internal TriangleAnalyzerManager()
        {
        }

        void IManager.Assignment()
        {

            Console.WriteLine("Welcome to Triangle Analyzer!  Enter the 3 lengths of the triange!\n\n");
            int SideALength = GetSideLength("A");
            int SideBLength = GetSideLength("B");
            int SideCLength = GetSideLength("C");

            TriangleAnalyzer triangleAnalyzer = new TriangleAnalyzer(SideALength, SideBLength, SideCLength);
            //TODO BEN print results.


        }



        #region "Private Methods"

        private int GetSideLength(string SideName)
        {
            int SideLength;
            do
            {


                Console.WriteLine($"What is the Length of Side {SideName}?");

                string sSideLength = Console.ReadLine();

                if (!int.TryParse(sSideLength, out SideLength))
                {
                    Console.WriteLine("Check your format, enter an integer;  1, 2, 5, 10... etc.");
                }


            } while (SideLength > 0);
            return SideLength;
        }

#region

    }
}
