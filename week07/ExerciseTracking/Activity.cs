using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _durationMinutes;

        public Activity(DateTime date, int durationMinutes)
        {
            _date = date;
            _durationMinutes = durationMinutes;
        }
        public DateTime GetDate()
        {
            return _date;
        }
        public void SetDate(DateTime date)
        {
            _date = date;
        }
        public int GetDurationMinutes()
        {
            return _durationMinutes;
        }
        public void SetDurationMinutes(int durationMinutes)
        {
            _durationMinutes = durationMinutes;
        }
        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }
        public virtual double GetPace() { return 0; }
        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} Activity ({_durationMinutes}) min";
        }
    }
}