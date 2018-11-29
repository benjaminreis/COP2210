using System;
namespace COP2210.Assignment6
{
    internal class TriangleAnalyzer
    {
        internal TriangleAnalyzer(int SideALength, int SideBLength, int SideCLength)
        {
            this.SideALength = SideALength;
            this.SideBLength = SideBLength;
            this.SideCLength = SideCLength;
        }

        private int SideALength;
        private int SideBLength;
        private int SideCLength;



        #region "Internal Methods"

        internal int SideA()
        {
            return this.SideALength;
        }
        internal int SideB()
        {
            return this.SideBLength;
        }
        internal int SideC()
        {
            return this.SideCLength;
        }

        internal string TriangleType()
        {
            return "equilateral, isosceles, etc";
        }


        internal double Area()
        {
            return 0.0;
        }

        #endregion



        #region "Private Methods"





        #endregion
    }
}
