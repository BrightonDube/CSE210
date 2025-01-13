using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Generate the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);  // Random number between 1 and 100

        int userGuess;
        int numberOfGuesses = 0; 
        
        do
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            numberOfGuesses++;
            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            
        } while (userGuess != magicNumber);

        Console.WriteLine("You guessed it!");

        
    }
}