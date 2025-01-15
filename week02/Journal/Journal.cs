using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal;

public class Journal
{
    public List<string> _entries = new();
    Entry entry = new();
    public string _name;

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry._entryText);
    }
    public void DisplayAll()
    {
        Console.WriteLine($"Journal entries for {_name}:");
        foreach (string entry in _entries)
        {
            Console.WriteLine($"{entry}");
        }
    }

}
