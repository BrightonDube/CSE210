using System;
using EternalQuest;

// Exceeding Requirements:
// 1. Added try-catch blocks for file operations to handle errors gracefully.
// 2. Included more descriptive messages to the user for better feedback.
// 3. Refactored repetitive code into helper methods where appropriate.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new();
        goalManager.Start();
    }
}