using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal myJournal = new();
        var myJourn = myJournal.Entries = new() { "Today I went to work", "I bought a 2 liter bottle of juice", "Then I was shopping for a flight ticket to CT" };
        string name = myJournal.Name = "Brighton";
        Console.WriteLine($"My name is {name}");
        
        foreach (string item in myJourn)
        {
            Console.WriteLine($"{item}");
        }
      
    }
}