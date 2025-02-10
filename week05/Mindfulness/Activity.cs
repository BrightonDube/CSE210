using System;
using System.Threading;
using System.Collections.Generic;

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
            Console.Clear();
        }
        public void ShowSpinner(int seconds)
        {

            List<string> spinnerCharacters = new List<string> { "|", "/", "-", "\\" };
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);
            int characterIndex = 0;
            Console.CursorLeft = 0; // New

            Console.Write("       ");
            Thread.Sleep(500);


            while (DateTime.Now < futureTime)
            {
                //   Console.Write("\b");
                Console.CursorLeft = 0;
                Console.Write($"{spinnerCharacters[characterIndex]}");
                Thread.Sleep(250);

                characterIndex = (characterIndex + 1) % spinnerCharacters.Count;
            }
            Console.Write("        ");
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.CursorLeft = 0;

                Console.Write($"{i}");
                Thread.Sleep(500);

                Console.Write("\b \b");

            }


            Console.Write("\b \b");
            Console.WriteLine("\b \b");
        }
    }
}