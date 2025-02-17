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
        public override bool IsComplete()
        {
            return _isComplete;
        }
        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
        }
    }
}