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
                ShowBreathingAnimation(4);
                Console.WriteLine("Breathe out...");
                ShowBreathingAnimation(6);
            }

            DisplayEndingMessage();
        }
        private void ShowBreathingAnimation(int seconds)
        {
            string breatheIn = " . . . . . . . . . . . . . . ";
            string breatheOut = " . . . . . . . . . ";

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);

            while (DateTime.Now < futureTime)
            {
                Console.CursorLeft = 0;

                Console.Write(breatheIn);
                Thread.Sleep(500);
                Console.CursorLeft = 0;
                Console.Write(breatheOut);
                Thread.Sleep(500);
                Console.WriteLine("\b \b \b");
            }
        }
    }
}
