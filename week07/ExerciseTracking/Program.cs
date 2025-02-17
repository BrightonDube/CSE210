using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();


        Running running = new Running(DateTime.Now.AddDays(-1), 30, 4.8);
        Cycling cycling = new Cycling(DateTime.Now.AddDays(-2), 45, 25.0);
        Swimming swimming = new Swimming(DateTime.Now.AddDays(-3), 60, 50);


        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}