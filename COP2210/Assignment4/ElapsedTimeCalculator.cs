using System;
namespace COP2210.Assignment4
{
    internal class ElapsedTimeCalculator
    {
        private int _StartTime;
        private int _EndTime;
        private DateTime _EndDateTime;

        internal ElapsedTimeCalculator(int StartTime, int EndTime)
        {
            this._EndTime = EndTime;
            this._StartTime = StartTime;
            CalculateInputsDateTime();
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

        internal DateTime StartDateTime { get; set; }
        internal DateTime EndDateTime { get; set; }

        private void CalculateInputsDateTime()
        {
           this.StartDateTime = DateTime.ParseExact(this._StartTime.ToString(), "HHmm", System.Globalization.CultureInfo.CurrentCulture);
            this._EndDateTime = DateTime.ParseExact(this._EndTime.ToString(), "HHmm", System.Globalization.CultureInfo.CurrentCulture);

        }

        internal int HourPortionElapsedTime()
        {
            return CalculateElapsedTime().Hours;

        }

        internal int MinutePortionElapsedTime()
        {
            return CalculateElapsedTime().Minutes;
        }

        //internal int TotalElapsedTimeMinutes()
        //{
        //    //todo ben implement later
        //}

        //internal int TotalElapsedTimeSeconds()
        //{
        //    //todo ben implement later
        //}


        internal TimeSpan CalculateElapsedTime()
        {
            var elapsed = this._EndDateTime - this.StartDateTime;

            return elapsed;

        }


    }
}
