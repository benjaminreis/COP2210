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

        private readonly int SideALength;
        private readonly int SideBLength;
        private readonly int SideCLength;



        #region "Internal Methods"

        internal int sideA()
        {
            return this.SideALength;
        }
        internal int sideB()
        {
            return this.SideBLength;
        }
        internal int sideC()
        {
            return this.SideCLength;
        }

        internal string getTriangleType()
        {
            string TriangleType = string.Empty;
            if (!isTriangle())
            {
                return "Not a Triangle";
            }

            if (isEquilateral())
            {
                return "Equilateral";
            }

            if (isRight())
            {
                TriangleType = "Right";
            }
            else if (isObtuse())
            {
                TriangleType = "Obtuse";
            }
            else
            {
                TriangleType = "Acute";
            }


            if (isIsosceles())
            {
                TriangleType = "Isocelese " + TriangleType;
            }

            return TriangleType;
        }


        internal double getArea()
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

        internal bool isTriangle()
        {
            int Side1 = this.SideALength;
            int Side2 = this.SideBLength;
            int Side3 = this.SideCLength;

            return ((Side1 + Side2) >= Side3) && ((Side3 + Side1) >= Side2) && ((Side2 + Side3) >= Side1);
        }

        #endregion



        #region "Private Methods"

        private bool isEquilateral()
        {
            if (this.SideALength == this.SideBLength && this.SideCLength == this.SideBLength && this.SideALength == this.SideCLength)
            {
                return true;
            }
            return false;
        }

        private bool isIsosceles()
        {
            if ((this.SideALength == this.SideBLength && this.SideALength != this.SideCLength)
                || (this.SideBLength == this.SideCLength && this.SideCLength != this.SideALength)
                || (this.SideCLength == this.SideALength && this.SideCLength != this.SideBLength))
            {
                return true;
            }
            return false;
        }

        private bool isRight()
        {
            //I think that it doesnt matter the the first two that are passed int... 
            // that it just matters that the 3rd param has each side
            if (squareSidesEqualThird(SideALength, SideBLength, SideCLength) 
                || squareSidesEqualThird(SideBLength, SideALength, SideCLength) 
                || squareSidesEqualThird(SideCLength, SideBLength, SideALength))               
            {
                return true;
            }

            return false;
        }

        private bool isObtuse()
        {
            if((sumSquaresTwoSide(this.SideALength, this.SideBLength) < (this.SideCLength * this.SideCLength))
               || (sumSquaresTwoSide(this.SideALength, this.SideCLength) < (this.SideBLength * this.SideBLength))
              || (sumSquaresTwoSide(this.SideCLength, this.SideBLength) < (this.SideALength * this.SideALength)))
            {
                return true;
            }

            return false;
        }


        private bool squareSidesEqualThird(int Side1, int Side2, int Side3)
        {
            return sumSquaresTwoSide(Side1, Side2) == Side3 * Side3 ? true : false;
        }

        private int sumSquaresTwoSide(int Side1, int Side2)
        {
            int returnValue = new int();


            returnValue = (Side1 * Side1) + (Side2 * Side2);


            return returnValue;
        }



        #endregion
    }
}
