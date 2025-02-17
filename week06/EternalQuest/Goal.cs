using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        private string _shortName;
        private string _description;
        private int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }
        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public string GetDetailsString()
        {
            return $"Short Name: {_shortName}\nDescription: {_description}\nPoints: {_points} ";
        }
        public string GetStringRepresentation()
        {
            return $"Goal: {_shortName} - {_description} - {_points} points";
        }
    }
}