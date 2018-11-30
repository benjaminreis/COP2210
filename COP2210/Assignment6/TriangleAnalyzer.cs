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

        internal string GetTriangleType()
        {
            string TriangleType = string.Empty;
            if (!IsTriangle())
            {
                return "Not a Triangle";
            }

            if (IsEquilateral())
            {
                return "Equilateral";
            }

            if (IsRight())
            {
                TriangleType = "Right";
            }
            else if (IsObtuse())
            {
                TriangleType = "Obtuse";
            }
            else
            {
                TriangleType = "Acute";
            }


            if (IsIsosceles())
            {
                TriangleType = "Isocelese " + TriangleType;
            }

            return TriangleType;
        }


        internal double GetArea()
        {
            int Side1 = this.SideALength;
            int Side2 = this.SideBLength;
            int Side3 = this.SideCLength;
            int perimeter = Side1 + Side2 + Side3;
            double s = perimeter / 2.0;

            var radicand = s * (s - Side1) * (s - Side2) * (s - Side3);

            if (radicand <= 0)
            {
                return 0.0;
            }
            return Math.Sqrt(radicand);
        }

        internal bool IsTriangle()
        {
            int Side1 = this.SideALength;
            int Side2 = this.SideBLength;
            int Side3 = this.SideCLength;

            return ((Side1 + Side2) >= Side3) && ((Side3 + Side1) >= Side2) && ((Side2 + Side3) >= Side1);
        }

        #endregion



        #region "Private Methods"

        private bool IsEquilateral()
        {
            if (this.SideALength == this.SideBLength && this.SideCLength == this.SideBLength && this.SideALength == this.SideCLength)
            {
                return true;
            }
            return false;
        }

        private bool IsIsosceles()
        {
            if ((this.SideALength == this.SideBLength && this.SideALength != this.SideCLength)
                || (this.SideBLength == this.SideCLength && this.SideCLength != this.SideALength)
                || (this.SideCLength == this.SideALength && this.SideCLength != this.SideBLength))
            {
                return true;
            }
            return false;
        }

        private bool IsRight()
        {
            //I think that it doesnt matter the the first two that are passed int... 
            // that it just matters that the 3rd param has each side
            if (SquareSidesEqualThird(SideALength, SideBLength, SideCLength) 
                || SquareSidesEqualThird(SideBLength, SideALength, SideCLength) 
                || SquareSidesEqualThird(SideCLength, SideBLength, SideALength))               
            {
                return true;
            }

            return false;
        }

        private bool IsObtuse()
        {
            if((SumSquaresTwoSide(this.SideALength, this.SideBLength) < (this.SideCLength * this.SideCLength))
               || (SumSquaresTwoSide(this.SideALength, this.SideCLength) < (this.SideBLength * this.SideBLength))
              || (SumSquaresTwoSide(this.SideCLength, this.SideBLength) < (this.SideALength * this.SideALength)))
            {
                return true;
            }

            return false;
        }


        private bool SquareSidesEqualThird(int Side1, int Side2, int Side3)
        {
            return SumSquaresTwoSide(Side1, Side2) == Side3 * Side3 ? true : false;
        }

        private int SumSquaresTwoSide(int Side1, int Side2)
        {
            int returnValue = new int();


            returnValue = (Side1 * Side1) + (Side2 * Side2);


            return returnValue;
        }



        #endregion
    }
}
