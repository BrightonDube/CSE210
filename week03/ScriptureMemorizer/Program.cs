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

            string isHidden = $"{s1.IsCompletelyHidden()}";
            Console.WriteLine($"{isHidden}");
        }
    }
}