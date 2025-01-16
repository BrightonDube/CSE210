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
        private DateTime theCurrentTime;

        public Entry()
        {
            theCurrentTime = DateTime.Now; // Initialize in the constructor
        }
        
        public void Display()
        {                   
            Console.WriteLine($"{theCurrentTime.ToShortDateString()} {_entryText}");
        }
    }
}