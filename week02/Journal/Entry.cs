using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class Entry
    {
        public DateTime entryTime { get; set; }
        public string _promptText { get; set; }
        public string _entryText { get; set; }

        public Entry()
        {
            entryTime = DateTime.Now; 
        }
        
        public void Display()
        {                   
            Console.WriteLine($"{entryTime.ToShortDateString()} {_entryText}");
        }
    }
}