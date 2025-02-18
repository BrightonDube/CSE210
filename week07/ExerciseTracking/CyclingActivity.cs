using System;

namespace ExerciseTracking
{
    public class CyclingSpeed : Activity
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

    }
}