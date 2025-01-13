using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 4;
        int y = 5;
        int sum = x + y;
        Console.WriteLine("The sum of x and y is: " + sum);
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        Console.WriteLine("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {color}");

        int number = 42;
        string numberString = number.ToString();
        Console.WriteLine($"The number {number} is a string: {numberString}");
    }
}