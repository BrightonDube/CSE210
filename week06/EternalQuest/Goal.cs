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
        public virtual string GetDetailsString()
        {
            return $"Description: {_description}";
        }
        public abstract string GetStringRepresentation();

        public string GetShortName()
        {
            return _shortName;
        }
        public int GetPoints()
        {
            return _points;
        }
        public string GetDescription()
        {
            return _description;
        }
    }
}