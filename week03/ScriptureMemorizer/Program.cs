using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    class Program 
    {
        static void Main(string[] args)
        {
            Reference r1 = new("Genesis", 1, 1, 5);
            string _text = "In the beginning God Created Heaven and Earth";
            Scripture s1 = new Scripture(r1, _text);
            bool toContinue = true;
            string userInput;
            
            while (toContinue)
            {
            Console.WriteLine($"{r1.GetDisplayText()} {s1.GetDisplayText()}");
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            if (userInput == "" || userInput.ToLower() == "quit")
            {
                toContinue = false;
            }

                            
            }
            
        }
    }
}