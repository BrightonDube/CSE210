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
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public Activity()
        {
        
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
        }
        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name} activity.\n");
            Console.WriteLine($"This activity will help you {_description}\n");
        }
        public void DisplayEndingMessage()
        {
            Console.WriteLine("Thank you for using the Mindfulness app");
        }
       public void ShowSpinner(int seconds)
       {
            Console.Write("Get Ready "); 

            for (int i = 0; i < seconds * 2; i++) 
            {
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
                Console.WriteLine("\rCountdown: {0} seconds", i);

            }
        }



    }
}