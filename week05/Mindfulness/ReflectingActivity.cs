using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;
        private List<string> _usedPrompts; 
        private List<string> _usedQuestions; 

        public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            _prompts = new List<string>()
            {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            };
            _questions = new List<string>()
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
             _usedPrompts = new List<string>(); 
             _usedQuestions = new List<string>();

        }
        private Random _random = new Random();
        public void Run()
        {
            DisplayStartingMessage();
            SetDuration();
            Console.WriteLine("Consider the following prompt:\n");
            string prompt = GetRandomPrompt(); 
            Console.WriteLine($"--- {prompt} ---\n");
            _usedPrompts.Add(prompt); 
            Console.WriteLine("When you have something in mind, press enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following question as they relate to this experience.");
            Console.Write("You may begin in: \n");
            ShowCountDown(5);
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {
                DisplayQuestions();
                ShowSpinner(5);
            }
            DisplayEndingMessage();
            _usedQuestions.Clear();
        }
        public string GetRandomPrompt()
        {
           if (_prompts.Count == _usedPrompts.Count) 
           {
            _usedPrompts.Clear();
           }
          
           List<string> availablePrompts = _prompts.Except(_usedPrompts).ToList();
          
           return availablePrompts[_random.Next(availablePrompts.Count)]; 
        }
        public string GetRandomQuestion()
        {
            if (_questions.Count == _usedQuestions.Count) 
            {
                _usedQuestions.Clear();
            }
            
            List<string> availableQuestions = _questions.Except(_usedQuestions).ToList();

            string question = availableQuestions[_random.Next(availableQuestions.Count)]; 

            _usedQuestions.Add(question); 
            return question;
        }

        public void DisplayQuestions()
        {
            Console.WriteLine(GetRandomQuestion());
        }

    }
}