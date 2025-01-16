using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal
{
    public class PromptGenerator
    {
        public List<string> _prompts = new List<string>();
    private string _lastPrompt;

    public string GetRandomPrompt()
    {   
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }

        Random random = new Random();
        string prompt;

        do
        {
            int randomIndex = random.Next(_prompts.Count);
            prompt = _prompts[randomIndex];
        } while (prompt == _lastPrompt && _prompts.Count > 1);

        _lastPrompt = prompt;
        return prompt;
    }
    }
}