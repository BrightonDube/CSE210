using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal;
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new();
        PromptGenerator promptGenerators = new(); 
        Entry entry = new(); 
        promptGenerators._prompts = new() { "What was your favorite memory from today?", "What's your favorite thing about the weather?", "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
        myJournal._entries = new();        
        
        DisplayMenu();
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            entry._entryText = Console.ReadLine();
        }
        else if (choice == 2)
        {
            myJournal.DisplayAll();
        }
        else if (choice == 3 || choice == 4)
        {
            Console.WriteLine("What is the filename? ");
            myJournal._fileName = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Goodbye!");
        }
                
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