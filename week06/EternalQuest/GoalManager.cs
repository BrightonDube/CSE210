using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }
        public void Start()
        {
            string choice = "";
            while (choice != "6")
            {
                Console.WriteLine($"You have {_score} points.\n");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
         public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Player Score: {_score}");
        }

         public void ListGoalNames()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created yet.");
                return;
            }

            Console.WriteLine("Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }
        }
         public void ListGoalDetails()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created yet.");
                return;
            }

            Console.WriteLine("Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                string completionStatus = _goals[i].IsComplete() ? "[X]" : "[ ]";
                string details = $"{i + 1}. {completionStatus} {_goals[i].GetShortName()} ({_goals[i].GetDetailsString()})";
                if (_goals[i] is ChecklistGoal checklistGoal)
                {
                    details = $"{i + 1}. {completionStatus} {_goals[i].GetShortName()} ({checklistGoal.GetAmountCompleted()}/{checklistGoal.GetTarget()})";
                }
                Console.WriteLine(details);
            }
        }

         public void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string goalType = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            if (!int.TryParse(Console.ReadLine(), out int points))
            {
                Console.WriteLine("Invalid input for points. Goal creation cancelled.");
                return;
            }

            switch (goalType)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    Console.WriteLine("Simple Goal Created");
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    Console.WriteLine("Eternal Goal Created");
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    if (!int.TryParse(Console.ReadLine(), out int target))
                    {
                        Console.WriteLine("Invalid input for target. Goal creation cancelled.");
                        return;
                    }
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    if (!int.TryParse(Console.ReadLine(), out int bonus))
                    {
                        Console.WriteLine("Invalid input for bonus. Goal creation cancelled.");
                        return;
                    }
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    Console.WriteLine("Checklist Goal Created");
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Goal creation cancelled.");
                    break;
            }
        }
        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created yet.  Create a goal first.");
                return;
            }

            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }

            Console.Write("Which goal did you accomplish? ");
            if (!int.TryParse(Console.ReadLine(), out int goalIndex) || goalIndex < 1 || goalIndex > _goals.Count)
            {
                Console.WriteLine("Invalid goal number.");
                return;
            }

            Goal goal = _goals[goalIndex - 1];

            if (goal.IsComplete())
            {
                Console.WriteLine("You have already completed this goal.");
                return;
            }

            goal.RecordEvent();
            _score += goal.GetPoints();
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus();
            }
            Console.WriteLine($"Congratulations! You earned {goal.GetPoints()} points.");
            DisplayPlayerInfo();
        }

        public void SaveGoals()
        {
            Console.Write("What is the name of the file to save the goals in: ");
            string filename = Console.ReadLine();

            try
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(_score);

                    foreach (Goal goal in _goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }

                }
                Console.WriteLine("Goals saved successfully.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save goals: {ex.Message}");
            }
        }
        





    }
}