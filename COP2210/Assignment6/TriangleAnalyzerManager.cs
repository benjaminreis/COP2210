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

            Console.Write($"Side A length: {triangleAnalyzer.SideA()}\n");
            Console.Write($"Side B length: {triangleAnalyzer.SideB()}\n");
            Console.Write($"Side C length: {triangleAnalyzer.SideC()}\n");
            string TriangleSuccessMessage = triangleAnalyzer.IsTriangle() ? "Yes!  This is a triangle" : "Nope! Not a Triangle";
            Console.WriteLine(TriangleSuccessMessage + "\n");
            Console.Write($"Triangle Type: {triangleAnalyzer.GetTriangleType()}\n");
            Console.Write($"Triangle Area: {triangleAnalyzer.GetArea()}");

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


            } while (SideLength < 1);
            return SideLength;
        }

#endregion

    }
}
