using System;

class Program
{
    static void Main(string[] args)
    {
        string activity = "";
        string action = "";
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflecting activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        if (choice == "1") 
        {
            Console.WriteLine("You have selected option 1");
            activity = "breathing";
            action = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

        }
        else if (choice == "2")
        {
            Console.WriteLine("You have selected option 2");
            activity = "reflecting";
            action = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if (choice == "3")
        {
            Console.WriteLine("You have selected option 3");
            activity = "listing";
            action = "reflect on the good things in your life by having you list as many things a you can  in a certain area";
        }
        else if (choice == "4")
        {
            Console.WriteLine("Goodbye");
        }
        Console.WriteLine($"Welcome to the {activity.ToUpper()} Activity.");
        Console.WriteLine($"This activity will help you {action}");
        Console.Write("How long, in seconds, would you like for your session? ");
        int timer = Convert.ToInt32(Console.ReadLine());
    }
}