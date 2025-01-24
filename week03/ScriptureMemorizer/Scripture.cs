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

        public Scripture(Reference reference, string text)
        {
           _reference = reference;
           _words = new();
           string[] wordsArray = text.Split(' ');

           foreach (string wordString in wordsArray)
           {
                Word word = new(wordString);
                _words.Add(word);               
           }

        }  

        public int GetWordCount()
        {
            return _words.Count;
        }
        public void HideRandomWords(int numberToHide)
        {
            _words[numberToHide].Hide();
        }     
        public string GetDisplayText()
        {
            string displayedScripture = "";
            foreach (Word word in _words)
            {
                displayedScripture += word.GetDisplayText() + " "; 
            }
            return displayedScripture.TrimEnd();
            
        }    
        public bool IsCompletelyHidden()
        {
            
            foreach (Word word in _words)
            {
            bool allMatch = word.GetText().All(c => c == '_');
            }
            return true;
        }              

        
    }
}