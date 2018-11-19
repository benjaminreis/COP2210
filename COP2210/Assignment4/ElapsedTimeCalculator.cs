using System;
namespace COP2210.Assignment4
{
    internal class ElapsedTimeCalculator
    {
        private int _StartTime;
        private int _EndTime;
        private DateTime _EndDateTime;
        private TimeSpan _ElapsedTime;
        private const int HOURMINSECCONVERSION = 60;
        private const int DAYHOURCONVERSION = 24;

        internal ElapsedTimeCalculator(int StartTime, int EndTime)
        {
            this._EndTime = EndTime;
            this._StartTime = StartTime;
            //CalculateInputsDateTime();
            CalculateElapsedTime();
        }

        internal ElapsedTimeCalculator() { }



        internal int StartTime
        {
            get { return _StartTime; }
            set 
            {
                _StartTime = value;
                CalculateElapsedTime();
            }
        }

        internal int EndTime
        {
            get { return _EndTime; }
            set 
            { 
                _EndTime = value;
                CalculateElapsedTime();
            }
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
            return this._ElapsedTime.Hours;

        }

        internal int MinutePortionElapsedTime()
        {
            return this._ElapsedTime.Minutes;
        }

        internal int TotalElapsedTimeMinutes()
        {

            var HoursInMinutes = this._ElapsedTime.Hours * HOURMINSECCONVERSION;
            var Minutes = this._ElapsedTime.Minutes;
            //so far keep as integer..  var SecondsInMInutes = this._ElapsedTime.Seconds / 60;
            return HoursInMinutes + Minutes;
        }

        internal int TotalElapsedTimeSeconds()
        {
            var HoursInSeconds = this._ElapsedTime.Hours * HOURMINSECCONVERSION * HOURMINSECCONVERSION;
            var MinInSeconds = this._ElapsedTime.Minutes * HOURMINSECCONVERSION;
            var Seconds = this._ElapsedTime.Seconds;

            return HoursInSeconds + MinInSeconds + Seconds;
        }


        internal void CalculateElapsedTime()
        {
            var elapsed = this._EndDateTime - this.StartDateTime;

            this._ElapsedTime = elapsed;

        }


    }
}
