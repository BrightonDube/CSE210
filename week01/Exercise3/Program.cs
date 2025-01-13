using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int userGuess = int.Parse(Console.ReadLine());
    }
}