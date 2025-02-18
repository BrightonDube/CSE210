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

        public override double GetPace()
        {
            double distance = GetDistance();
            if (distance == 0)
            {
                return 0;
            }
            return GetDurationMinutes() / distance;
        }
        public override string GetSummary()
        {
            return $"{GetDate():dd MMM yyy} Swimming ({GetDurationMinutes()} min) Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        }
    }
}