using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Journal
    {
    public class Journal
    {
        public List<Entry> _entries = new();
        //Entry entry = new();
        public string _fileName;
        public void SaveToFile(string filename)
        {
            try
            {
                // File.WriteAllLines(filename, _entries);
                // Console.WriteLine("Journal saved successfully!");
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(_entries, options);
                File.WriteAllText(filename, jsonString);
                Console.WriteLine("Journal saved to file successfully.");
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
                    // string[] lines = File.ReadAllLines(filename);
                    // _entries.Clear(); // Clear existing entries before loading
                    // foreach (string line in lines)
                    // {
                    //     _entries.Add(line);
                    // }
                    string jsonString = File.ReadAllText(filename);
                    var loadedEntries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
                    if (loadedEntries != null)

                    {
                        _entries = loadedEntries;
                        Console.WriteLine("Journal loaded successfully!");
                        
                    }
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
            // _entries.Add($"Date: {entry.entryTime} Prompt: {entry._promptText} /n{entry._entryText}");
            _entries.Add(entry);
        }
        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"{entry}");
            }
            return;
        }

    }
}