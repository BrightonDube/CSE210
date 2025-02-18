using System;

namespace ExerciseTracking
{
    public class SwimmingActivity : Activity
    {
        private int _laps;

        public SwimmingActivity(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
        {
            _laps = laps;
        }
        public int GetLaps()
        {
            return _laps;
        }
        public void SetLaps(int laps)
        {
            _laps = laps;
        }
        public override double GetDistance()
        {
            return GetLaps() * 50.0 / 1000.0;
        }
        public override double GetSpeed()
        {
            return (GetDistance() / GetDurationMinutes()) * 60;
        }
    }
}