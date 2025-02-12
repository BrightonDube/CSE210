using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, string points) : base(name, description, points)
        {
            _isComplete = false;

        }

        public void RecordEvent()
        {
            _isComplete = true;
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