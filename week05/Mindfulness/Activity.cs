using System;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        private string _name;
        private string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void SetDuration()
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string durationInput = Console.ReadLine();
            if (int.TryParse(durationInput, out int duration))
            {
                _duration = duration;
            }
            else
            {
                Console.WriteLine("Invalid input. Setting duration to 30 seconds.");
                _duration = 30;
            }
            Console.Clear();
            Console.WriteLine("Get ready ...");
            ShowSpinner(3);
        }
        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} activity.\n");
            Console.WriteLine($"This activity will help you {_description}\n");

        }

        //public void Run();
        public void DisplayEndingMessage()
        {
            Console.WriteLine("Well done!");
            ShowSpinner(1);
            Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
            ShowSpinner(2);
        }
        public void ShowSpinner(int seconds)
        {

            for (int i = 0; i < seconds; i++)
            {
                Console.Write("|");
                Thread.Sleep(250);

                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(250);

                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(250);

                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(250);

                Console.Write("\b \b");
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b \b");
            }

            Console.WriteLine();
        }
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\r{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\r");
        }
    }
}