using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {

        }
        public override void RecordEvent()
        {
            Console.WriteLine($"You have recorded progress on the eternal goal: {GetShortName()}");
        }
    }
}