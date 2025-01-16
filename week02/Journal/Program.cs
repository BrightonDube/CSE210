using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new();
            PromptGenerator promptGenerators = new(); 
            Entry entry = new(); 
            promptGenerators._prompts = new() { "What was your favorite memory from today?", "What's your favorite thing about the weather?", "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
            myJournal._entries = new();        
            
              

            // if (!int.TryParse(input, out choice))
            // {
            //     Console.WriteLine("Invalid choice. Please enter a valid number.");
            //     return;
            // }
            DisplayMenu();
            string choice = Console.ReadLine();
            do
            {   
                DisplayMenu();
                choice = Console.ReadLine(); 
                switch (choice)
                {
                    case "1":
                        entry._promptText = promptGenerators.GetRandomPrompt();
                        Console.WriteLine($"{entry._promptText}");
                        entry._entryText = Console.ReadLine();
                        break;                    
                    case "2":
                        myJournal.DisplayAll();
                        break;
                    case "3":
                    case "4":
                        Console.WriteLine("What is the filename? ");
                        myJournal._fileName = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Goodbye!");
                        break;
                }
                
            } while (choice != "5");

                                
            //Console.WriteLine($"{promptGenerators.GetRandomPrompt()}");
            //myJournal.DisplayAll();
            //entry.Display();
        
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Write your entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load File");
            Console.WriteLine("4. Save File");
            Console.WriteLine("5. Quit Program");
            Console.WriteLine("What would you like to do? ");
            Console.Write(">");       
        }
    }
}