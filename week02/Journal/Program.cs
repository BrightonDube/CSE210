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
        Entry entry = new Entry();
        entry._entryText = "Hello";

        promptGenerators._prompts = new() { "What was your favorite memory from today?", "What's your favorite thing about the weather?", "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
        myJournal._entries = new() { "Today I went to work", "I bought a 2 liter bottle of juice", "Then I was shopping for a flight ticket to CT" };        
        string name = myJournal._name = "Brighton";

        Console.WriteLine($"My name is {name}");        
        
        Console.WriteLine($"{promptGenerators.GetRandomPrompt()}");
        //myJournal.DisplayAll();
        //entry.Display();

      
    }
    public void DisplayMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Write your entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Load File");
        Console.WriteLine("3. Save File");
        Console.WriteLine("3. Quit Program");
        Console.WriteLine("What would you like to do? ");       
    }
}