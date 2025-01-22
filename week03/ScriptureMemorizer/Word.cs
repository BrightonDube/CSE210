using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    public class Word
    {
        string _text;
        bool _isHidden = false;
        public Word(string text)
        {
           _text = text;
        }

    }
}