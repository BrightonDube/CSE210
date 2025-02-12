using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class Goal
    {
        private string _shortName;
        private string _description;
        private string _points;

        public Goal(string name, string description, string points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }
        public static void RecordEvent()
        {

        }
        public bool IsComplete()
        {
            return false;
        }
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