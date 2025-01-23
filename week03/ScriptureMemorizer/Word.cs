using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;
        public Word(string text)
        {
           _text = text;
           _isHidden = false;
        }
        public string GetText()
        {
            return _text;
        }
        public void SetText(string text)
        {
            _text = text;
        }
        public void Hide()
        {

        }

    }
}