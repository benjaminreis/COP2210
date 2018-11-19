using System;
namespace COP2210.Assignment4
{
    internal class ElapsedTimeCalculator
    {
        private int _StartTime;
        private int _EndTime;

        internal ElapsedTimeCalculator(int StartTime, int EndTime)
        {
            this._EndTime = EndTime;
            this._StartTime = StartTime;
        }


        internal int StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        internal int EndTime
        {
            get { return _EndTime; }
            set { _EndTime = value; }
        }





    }
}
