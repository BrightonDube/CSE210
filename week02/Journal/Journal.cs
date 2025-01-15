using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal;

public class Journal
{
    public List<string> _entries = new();
    public string _name;
    public void Display()
    {
        Console.WriteLine($"My journal entries for {_name}:");
        foreach (string entry in _entries)
        {
            Console.WriteLine($"{entry}");
        }
    }

}
