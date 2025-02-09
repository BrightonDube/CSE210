using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
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
                Console.Clear();
                activityName = "Breathing";
                description = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

            }
            else if (choice == "2")
            {
                Console.Clear();
                activityName = "Reflecting";
                description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            }
            else if (choice == "3")
            {
                Console.Clear();
                activityName = "Listing";
                description = "reflect on the good things in your life by having you list as many things a you can  in a certain area";
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Goodbye");
            }

            Activity activity = new(activityName, description);
            activity.DisplayStartingMessage();
            activity.SetDuration();
            
        }
    }
}