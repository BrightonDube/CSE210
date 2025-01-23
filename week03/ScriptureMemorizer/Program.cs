using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    public class Program
    {
        private static Reference r1 = new("Genesis", 1, 1, 5);
        private static string _text = "In the beginning God Created Heaven and Earth";
        private static Scripture s1 = new Scripture(r1, _text);

        private string isHidden = $"{s1.IsCompletelyHidden()}";

       
    }
}