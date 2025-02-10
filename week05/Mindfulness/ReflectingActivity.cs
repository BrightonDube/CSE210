using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;
        private List<string> _usedPrompts;

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
        }

        private Random _random = new Random();
        public void Run()
        {
            DisplayStartingMessage();
            SetDuration();
            Console.WriteLine("Consider the following prompt:\n");
            string prompt = GetRandomPrompt();
            Console.WriteLine($"--- {prompt} ---\n");
            Console.WriteLine("When you have something in mind, press enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following question as they relate to this experience.");
            Console.Write("You may begin in: \n");
            ShowCountDown(5);

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            List<string> usedQuestions = new List<string>();
            Console.Clear();

            while (DateTime.Now < futureTime)
            {
                string question = GetRandomQuestion(usedQuestions);
                Console.WriteLine($"{question}");
                ShowSpinner(5);

            }

            DisplayEndingMessage();
        }
        private string GetRandomQuestion(List<string> usedQuestions)
        {
            if (_questions.Count == usedQuestions.Count)
            {
                usedQuestions.Clear();
            }

            string question;
            do
            {
                question = _questions[_random.Next(_questions.Count)];
            } while (usedQuestions.Contains(question));

            usedQuestions.Add(question);
            return question;
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

    }
}