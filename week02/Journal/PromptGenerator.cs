using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class PromptGenerator
    {
        public List<string> _prompts = new List<string>();
        
        public string GetRandomPrompt()
        {   
            Random random = new Random();
            int randomIndex = random.Next(_prompts.Count);
            string prompt = _prompts[randomIndex];
            return prompt;
        }
    }
}