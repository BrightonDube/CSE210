using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class PromptGenerator
    {
        public List<string> _prompts = new List<string>();
        
        public void DisplayPrompt()
        {   
            Random random = new Random();
            int randomIndex = random.Next(_prompts.Count);
            string prompt = _prompts[randomIndex];
            Console.WriteLine($"{prompt}");
        }
    }
}