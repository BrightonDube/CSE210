using System;
namespace Resumes;
class Program
{
    static void Main(string[] args)
    {
        Resume resume = new();
        Job job = new();
        
        resume._name = "Brighton Dube";
        resume._jobs.Add(job);
        job._companyName = "Microsoft Corporation";

        foreach (Job job1 in resume._jobs)
        {
            Console.WriteLine($"Company: {job1.GetJob()}");
        }

    }
}