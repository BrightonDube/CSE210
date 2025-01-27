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
            Reference r1 = new("Genesis", 1, 1);
            string _text = "In the beginning God Created Heaven and Earth";
            Scripture s1 = new Scripture(r1, _text);
            string userInput;
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine($"{r1.GetDisplayText()} {s1.GetDisplayText()}");
                Console.WriteLine("Press enter to continue or type 'quit' to finish");
                userInput = Console.ReadLine();
                if (s1.IsCompletelyHidden() || userInput.ToLower() == "quit")
                {
                    break;
                }
                else if (userInput == "")
                {
                    int randomIndex;
                    do {
                     randomIndex = rand.Next(0, s1.GetWordCount());
                    }while(s1.GetWordIsHidden(randomIndex)); 
                    
                    s1.HideRandomWords(randomIndex);
                }
                Console.Clear();
            }
        }
    }
}