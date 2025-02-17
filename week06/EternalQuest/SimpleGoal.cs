using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false;

        }

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($" Congratulations! You have completed the goal: {GetShortName()}");
        }
        public bool IsComplete()
        {
            return _isComplete;
        }
        public string GetStringRepresentation()
        {
            return $"{name} - {Description} - {Points} - {IsComplete()}";
        }
    }
}