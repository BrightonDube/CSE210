using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class Entry
    {
        public List<string> _entries = new();
        DateTime theCurrentTime = DateTime.Now;
        
        public void Display()
        {
            string dateText = theCurrentTime.ToShortDateString();
            foreach (string entry in _entries)
            {
                Console.WriteLine($"{dateText} {entry}");
            }
            
        }
    }
}