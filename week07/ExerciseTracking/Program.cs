using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        Running running = new Running(DateTime.Now.AddDays(-1), 30, 4.8);
        Cycling cycling = new Cycling(DateTime.Now.AddDays(-2), 45, 25.0);
        Swimming swimming = new Swimming(DateTime.Now.AddDays(-3), 60, 50);

        // Add activities to the list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Iterate through the list and display the summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}