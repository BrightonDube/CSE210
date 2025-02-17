using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }
        public override void RecordEvent()
        {
            _amountCompleted++;
            Console.WriteLine($"Recorded progress on checklist goal: {GetShortName()} ({_amountCompleted}/{_target})");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have completed the checklist goal: {GetShortName()} and earned a bonus of {_bonus} points!");
            }

        }


    }
}