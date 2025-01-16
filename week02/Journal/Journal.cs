using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
    {
    public class Journal
    {
        public List<string> _entries = new();
        Entry entry = new();
        public string _fileName;
        public void SaveToFile(string filename)
        {
            try
            {
                File.WriteAllLines(filename, _entries);
                Console.WriteLine("Journal saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }
        
        public void LoadFromFile(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);
                    _entries.Clear(); // Clear existing entries before loading
                    foreach (string line in lines)
                    {
                        _entries.Add(line);
                    }
                    Console.WriteLine("Journal loaded successfully!");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
        

        public void AddEntry(Entry entry)
        {
            _entries.Add($"Date: {entry.entryTime} Prompt: {entry._promptText} /n{entry._entryText}");
        }
        public void DisplayAll()
        {
            foreach (string entry in _entries)
            {
                Console.WriteLine($"{entry}");
            }
            return;
        }

    }
}