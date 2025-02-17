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
     }
}