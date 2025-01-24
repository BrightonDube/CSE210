using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private string _originalText;
        private bool _isHidden;
        public Word(string text)
        {
           _text = text;
           _originalText = text;
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
            _text = "";
            foreach (char letter in _text)
            {
                _text = _text + '_';                
            }
            _isHidden = true;
        }
        public void Show()
        {
            _text = _originalText;
            _isHidden = false;
        }
        public bool IsHidden()
        {
            foreach (char letter in _text)
            {
                if (letter != '_')
                {
                    _isHidden = false;
                }
                else
                {
                    _isHidden = true;
                }
            }
            return _isHidden;
        }
        public string GetDisplayText()
        {
            return _text;
        }

    }
}