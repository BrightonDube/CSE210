using System;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {

        }

        public void Run()
        {
            DisplayStartingMessage();
            SetDuration();
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(7);
                Console.WriteLine("Breathe out...");
                ShowCountDown(5);
            }

            DisplayEndingMessage();
        }
    }
}
