using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

}