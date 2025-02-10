using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creativity : the reflecting activity guarantees all prompts are used once
            while (true)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("\t1. Start breathing activity");
                Console.WriteLine("\t2. Start reflecting activity");
                Console.WriteLine("\t3. Start listing activity");
                Console.WriteLine("\t4. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    BreathingActivity breathingActivity = new();
                    breathingActivity.Run();
                }
                else if (choice == "2")
                {
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.Run();
                }
                else if (choice == "3")
                {
                    ListingActivity listingActivity = new();
                    listingActivity.Run();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}