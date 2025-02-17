using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private int _time;

        public Activity(int time)
        {
            _time = time;
        }
        public abstract int CalculateSpeed();
    }
}