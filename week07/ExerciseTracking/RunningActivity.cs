using System;

namespace ExerciseTracking
{
    public class RunningActivity : Activity
    {
        private double _distanceKilometers;
        public RunningActivity(DateTime date, int durationMinutes, double distanceKilometers) : base(date, durationMinutes)
        {
            _distanceKilometers = distanceKilometers;
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
            return GetDistanceKilometers();
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
            return $"{GetDate():dd MMM yyyy} Running ({GetDurationMinutes()} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
        }

    }

}