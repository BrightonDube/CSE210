using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class Entry
    {
        public string _promptText;
        public string _entryText;
        public DateTime entryTime;

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