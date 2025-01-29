using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScriptureMemorizer
{
    class Program
    {
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            string scripturesFilePath = "scriptures.json"; 
            List<ScriptureData> scriptures = new List<ScriptureData>();
            string jsonString = File.ReadAllText(scripturesFilePath);
            scriptures = JsonSerializer.Deserialize<List<ScriptureData>>(jsonString);

            // Reference r1 = new("Genesis", 1, 1);
            // string _text = "In the beginning God Created Heaven and Earth";
            //Scripture s1 = new Scripture(r1, _text);
            string userInput;
            
            while (true)
            {
                ScriptureData selectedScripture = scriptures[rand.Next(0, scriptures.Count)]; // this selects a random verse frm the list
                string scriptureText = string.Join("#", selectedScripture._verses);
                string[] referenceParts = selectedScripture._reference.Split(new char[]{':', '-'});
                Reference r1;
                if (referenceParts.Length == 3) {
                    r1 = new(referenceParts[0], int.Parse(referenceParts[1]), int.Parse(referenceParts[2]));
                } else if (referenceParts.Length == 4) {
                    r1 = new(referenceParts[0], int.Parse(referenceParts[1]), int.Parse(referenceParts[2]), int.Parse(referenceParts[3]));
                } else {
                   Console.WriteLine("Incorrect formatting in reference. Skipping it.");
                     continue;
                }
                Scripture s1 = new Scripture(r1, scriptureText);
                Console.WriteLine($"{r1.GetDisplayText()} \n{s1.GetDisplayText()}");
                Console.WriteLine("Press enter to continue or type 'quit' to finish");
                userInput = Console.ReadLine();
                if (s1.IsCompletelyHidden() || userInput.ToLower() == "quit")
                {
                    break;
                }
                else if (userInput == "")
                {
                     int verseIndex;
                    int wordIndex;
                    do {
                     verseIndex = rand.Next(0, s1._verses.Count);
                      wordIndex = rand.Next(0, s1._verses[verseIndex].Count);
                    }while(s1.GetWordIsHidden(verseIndex, wordIndex)); 
                    
                    s1.HideRandomWords(verseIndex, wordIndex);
                }
                Console.Clear();
            }
        }
    }
}