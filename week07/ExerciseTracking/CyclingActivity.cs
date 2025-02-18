using System;

namespace ExerciseTracking
{
    public class CyclingActivity : Activity
    {
        private double _speedKph;
        public CyclingActivity(DateTime date, int durationMinutes, double speedKph) : base(date, durationMinutes)
        {
            _speedKph = speedKph;
        }
        public double GetSpeedKph()
        {
            return _speedKph;
        }
        public void SetSpeedKph(double speedKph)
        {
            _speedKph = speedKph;
        }

        public override double GetDistance()
        {
            return (GetSpeedKph() / 60) * GetDurationMinutes();
        }
        public override double GetSpeed()
        {
            return GetSpeedKph();
        }
        public override double GetPace()
        {
            return 60 / GetSpeedKph();
        }
        public override string GetSummary()
        {
            return $"{GetDate():dd MMM yyyy} Cycling ({GetDurationMinutes()} min): Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        }

    }
}