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
        public abstract double GetDistance();

        public abstract double GetSpeed();
        public abstract double GetPace();
        public virtual string GetSummary()
        {
            return $"{GetDate():dd MMM yyyy} Activity ({GetDurationMinutes()}) min";
        }
    }
}