using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>(); //create a list to store the numbers
        int userInput;
        do
        {
            Console.Write("Enter a number to add to the list and 0 to stop adding: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput!= 0)
            {
                numList.Add(userInput);
            }
        } while (userInput != 0);

        Console.WriteLine("");
    }
}