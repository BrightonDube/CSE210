using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string activityName = "";
                string description = "";
                Console.WriteLine("Menu Options:");
                Console.WriteLine("\t1. Start breathing activity");
                Console.WriteLine("\t2. Start reflecting activity");
                Console.WriteLine("\t3. Start listing activity");
                Console.WriteLine("\t4. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;

                }
                else if (choice == "2")
                {
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.Run();
                }
                else if (choice == "3")
                {
                    activityName = "Listing";
                    description = "reflect on the good things in your life by having you list as many things a you can  in a certain area";
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye");
                }

                Activity activity = new(activityName, description);
                activity.DisplayStartingMessage();
                activity.SetDuration();
                activity.ShowSpinner(3);
                activity.DisplayEndingMessage();
                activity.ShowCountDown(5);

            }
        }
    }
}