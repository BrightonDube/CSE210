using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new();
            PromptGenerator promptGenerators = new();
            promptGenerators._prompts = new() { "What was your favorite memory from today?", "What's your favorite thing about the weather?", "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };

            DisplayMenu();
            string choice;

            do
            {
                Console.Write("> "); 
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Entry entry = new();
                        entry._promptText = promptGenerators.GetRandomPrompt();
                        Console.WriteLine($"{entry._promptText}");
                        entry._entryText = Console.ReadLine();
                        myJournal.AddEntry(entry); 
                        break;
                    case "2":
                        myJournal.DisplayAll();
                        break;
                    case "3":
                        Console.WriteLine("What is the filename to load? ");                
                        myJournal.LoadFromFile(Console.ReadLine()); 
                        break;
                    case "4":
                        Console.WriteLine("What is the filename to save? ");
                        myJournal.SaveToFile(Console.ReadLine());
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                if (choice != "5") 
                {
                    DisplayMenu();
                }

            } while (choice != "5");
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Write your entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load File");
            Console.WriteLine("4. Save File");
            Console.WriteLine("5. Quit Program");
            Console.WriteLine("What would you like to do? ");
        }       
        
    }
}