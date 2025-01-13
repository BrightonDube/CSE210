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

        List<int> numbers = new List<int>(10); // the variable numbers holds the list and to use the list a new instance has to be created using the new keyword 10 is the initial capacity

        List<string> words = new List<string>();
        numbers.Add(2);
        words.Add("mouse");

        Console.WriteLine($"List {numbers[0]}");
    }
}