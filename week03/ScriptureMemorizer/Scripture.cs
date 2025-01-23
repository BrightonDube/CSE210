using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private bool _isHidden = false;

        public Scripture(Reference reference, string text)
        {
           _reference = new("Genesis", 1, 1, 3);
           _words = new();       
        }  

        public void HideRandomWords(int numberToHide)
        {
            return;
        }     
        public string GetDisplayText()
        {
            return($"{_words}");
        }    
        public bool IsCompletelyHidden()
        {
            
            foreach (Word word in _words)
            {
            bool allMatch = word.GetText().All(c => c == '_');
            }

            // If we get to this point, it means ALL words are hidden.
            return true;
        }              

        
    }
}