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
        entry._entries = new() {"entry 1"};

        promptGenerators._prompts = new() { "What was your favorite memory from today?", "How was your day?", "What's your favorite thing about the weather?" };
        myJournal._entries = new() { "Today I went to work", "I bought a 2 liter bottle of juice", "Then I was shopping for a flight ticket to CT" };        
        string name = myJournal._name = "Brighton";

        Console.WriteLine($"My name is {name}");        
        
        Console.WriteLine($"{promptGenerators.GetRandomPrompt()}");
        myJournal.Display();
        entry.Display();

      
    }
}