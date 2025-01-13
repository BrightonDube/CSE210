using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>(); //create a list to store the numbers
        int userInput;
        int sumList = 0;
        double average;
        do
        {
            Console.Write("Enter a number to add to the list and 0 to stop adding: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput!= 0)
            {
                numList.Add(userInput);
            }
        } while (userInput != 0);
        for (int i = 0; i < numList.Count; i++)
        {
            sumList += numList[i];
        }
        average = sumList / numList.Count;
        Console.WriteLine($"Sum of numbers in the list is: {sumList}");
        Console.WriteLine($"Average of numbers in the list is: {average}");
        Console.WriteLine($"The largest number in the list is: {numList.Max()}");

    }
}