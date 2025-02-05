using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        List<string> _prompts;
        List<string> _questions;

        public ReflectingActivity()
        {
            _prompts = new List<string>();
        }
    }
}