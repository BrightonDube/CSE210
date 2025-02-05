using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;

        ListingActivity(int count, List prompts)
        {
            _count = count;
            _prompts = prompts;
        }
        public void Run()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_prompts[i]);

            }
            
        }
    }
}