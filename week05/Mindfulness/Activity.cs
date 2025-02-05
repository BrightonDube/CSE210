using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }
        public Activity()
        {
            _name = "John Smith";
            _description = "John Smith's activity";
            _duration = 0;
        }
        public void DisplayStartingMessage()
        {
            Console.WriteLine("Welcome to the Mindfulness app");
        }
        public void DisplayEndingMessage()
        {
            Console.WriteLine("Thank you for using the Mindfulness app");
        }
        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("\rSpinning... {0} seconds", i);
                System.Threading.Thread.Sleep(1000);

            }
        }
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine("\rCountdown: {0} seconds", i);

            }
        }



    }
}