using System;
namespace Resumes;
class Program
{
    static void Main(string[] args)
    {
        Resume resume = new();
        Job job = new();
        Job job2 = new();
        Job job3 = new();

        job._companyName = "Microsoft Corporation";        
        job._jobTitle = "Software Engineer";
        job._startYear = 2015;
        job._endYear = 2020;

        job2._companyName = "Meta";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2021;
        job2._endYear = 2022;

        job3._companyName = "Google";
        job3._jobTitle = "Software Engineer";
        job3._startYear = 2022;
        job3._endYear = 2023;
        
        resume._name = "Brighton Dube";
        resume._jobs = new List<Job> { job, job2, job3 };
        // resume._jobs.Add(job);
        // resume._jobs.Add(job2);
        // resume._jobs.Add(job3);
        

        // foreach (Job job1 in resume._jobs)
        // {
        //     job1.GetJob();
        // }
        resume.DisplayResume();

    }
}