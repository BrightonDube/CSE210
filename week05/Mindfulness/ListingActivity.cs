using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private static List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private List<string> _items = new List<string>();
        private Random _random = new Random();
        private int _count;

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }
        public void Run()
        {
            DisplayStartingMessage();
            SetDuration();
            Console.WriteLine("List as many responses to the following prompt:");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("You may begin in: \n");
            ShowCountDown(5);

            Console.WriteLine("Begin!");
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            _items = GetListFromUser(futureTime);

            _count = _items.Count;
            Console.WriteLine($"You listed {_count} items!");
            DisplayEndingMessage();
        }
        public string GetRandomPrompt()
        {
            return (_prompts[_random.Next(_prompts.Count)]);
        }
        public List<string> GetListFromUser(DateTime futureTime)
        {
            List<string> items = new List<string>();
            while (DateTime.Now < futureTime)
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                items.Add(item);
            }
            return items;
        }
    }
}