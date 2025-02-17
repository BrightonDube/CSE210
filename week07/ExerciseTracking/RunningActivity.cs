using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class RunningActivity : Activity
    {
        public RunningActivity()
        {
            private double _distanceKilometers;
            public Running(DateTime date, int durationMinutes, double _distanceKilometers) : base(date, durationMinutes)
            {
                _distanceKilometers = _distanceKilometers
            }

        }

    }
}