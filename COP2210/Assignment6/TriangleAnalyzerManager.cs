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
            int SideALength = getSideLength("A");
            int SideBLength = getSideLength("B");
            int SideCLength = getSideLength("C");

            TriangleAnalyzer triangleAnalyzer = new TriangleAnalyzer(SideALength, SideBLength, SideCLength);

            Console.Write($"Side A length: {triangleAnalyzer.sideA()}\n");
            Console.Write($"Side B length: {triangleAnalyzer.sideB()}\n");
            Console.Write($"Side C length: {triangleAnalyzer.sideC()}\n");
            string TriangleSuccessMessage = triangleAnalyzer.isTriangle() ? "Yes!  This is a triangle" : "Nope! Not a Triangle";
            Console.WriteLine(TriangleSuccessMessage + "\n");
            Console.Write($"Triangle Type: {triangleAnalyzer.getTriangleType()}\n");
            Console.Write($"Triangle Area: {triangleAnalyzer.getArea()}");

        }



        #region "Private Methods"

        private int getSideLength(string SideName)
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


            } while (SideLength < 1);
            return SideLength;
        }

#endregion

    }
}
