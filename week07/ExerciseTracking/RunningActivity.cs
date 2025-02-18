using System;

namespace ExerciseTracking
{
    public class RunningActivity : Activity
    {
        public RunningActivity()
        {
            private double _distanceKilometers;
        public RunningActivity(DateTime date, int durationMinutes, double _distanceKilometers) : base(date, durationMinutes)
        {
            _distanceKilometers = _distanceKilometers;
        }

        public double GetDistanceKilometers()
        {
            return _distanceKilometers;
        }
        public void SetDistanceKilometers(double distanceKilometers)
        {
            _distanceKilometers = distanceKilometers;
        }

        public override double GetDistance()
        {
            return _distanceKilometers;
        }
        public override double GetSpeed()
        {
            return (GetDistanceKilometers() / GetDurationMinutes()) * 60;
        }
        public override double GetPace()
        {
            return GetDurationMinutes() / GetDistanceKilometers();
        }
        public override string GetSummary()
        {
            return $"{GetDate(): dd MMM yyyy} Running ({GetDurationMinutes()} min): Distance {GetDistance(): F2} km, Speed {GetSpeed(): F2} km/h), Pace: {GetPace(): F2} min per km";
        }

    }


}
}