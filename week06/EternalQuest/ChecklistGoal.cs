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
        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return base.GetDetailsString() + $", Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
        }
        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";
        }
        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }
        public int GetTarget()
        {
            return _target;
        }
        public int GetBonus()
        {
            return _bonus;
        }
        public void SetAmountCompleted(int amountCompleted)
        {
            _amountCompleted = amountCompleted;
        }


    }
}