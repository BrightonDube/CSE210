using System;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Activity> activities = new List<Activity>();


            RunningActivity running = new RunningActivity(DateTime.Now.AddDays(-1), 30, 4.8);
            CyclingActivity cycling = new CyclingActivity(DateTime.Now.AddDays(-2), 45, 25.0);
            SwimmingActivity swimming = new SwimmingActivity(DateTime.Now.AddDays(-3), 60, 50);


            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);


            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}