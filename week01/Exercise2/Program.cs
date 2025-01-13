using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        float percentageGrade = float.Parse(Console.ReadLine());
        string grade = "";
        string sign = "";
        // if (percentageGrade >= 90)
        // {
        //     Console.WriteLine("Your grade is A");
        // }
        // else if (percentageGrade >= 80)
        // {
        //     Console.WriteLine("Your grade is B");
        // }
        // else  if (percentageGrade >= 70)
        // {
        //     Console.WriteLine("Your grade is C");
        // }
        // else if (percentageGrade >= 60)
        // {
        //     Console.WriteLine("Your grade is D");
        // }
        // else
        // {
        //     Console.WriteLine("Your grade is F");
        // }
        if (percentageGrade % 10 >= 7)
        {
            sign = "+";
        }
        else if (percentageGrade % 10 < 3)
        {
            sign = "-";
        }
        if (percentageGrade >= 90)
        {
            grade = "A";
            if (percentageGrade % 10 >= 7)
            {
                sign = "";
            }

        }
        else if (percentageGrade >= 80)
        {
            grade = "B";
        }
        else  if (percentageGrade >= 70)
        {
            grade = "C";
        }
        else if (percentageGrade >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
            sign = "";
        }

        Console.WriteLine($"Your grade is {grade}{sign}");

        if (percentageGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Better luck next time!");
        }
    }
}