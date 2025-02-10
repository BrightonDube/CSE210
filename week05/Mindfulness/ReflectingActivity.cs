using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private readonly List<string> _prompts;
        private readonly List<string> _questions;

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
        }
        private Random _random = new Random();
        public void Run()
        {
            DisplayStartingMessage();
            SetDuration();
            Console.WriteLine("Consider the following prompt:\n");
            Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
            Console.WriteLine("When you have something in mind, press enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following question as they relate to this experience.");
            Console.Write("You may begin in: \n");
            ShowCountDown(5);
            Console.Clear();
            // DisplayPrompt();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {
                DisplayQuestions();
                ShowSpinner(5);
            }

            DisplayEndingMessage();
        }
        public string GetRandomPrompt()
        {
            return _prompts[_random.Next(_prompts.Count)];
        }
        public string GetRandomQuestion()
        {
            return _questions[_random.Next(_questions.Count)];
        }
        // public void DisplayPrompt()
        // {
        //     Console.WriteLine(GetRandomPrompt());
        //     Console.WriteLine("Take a moment to reflect on this...");
        //     ShowSpinner(5);
        //}
        public void DisplayQuestions()
        {
            Console.Write(GetRandomQuestion());
        }

    }
}