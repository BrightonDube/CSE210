using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resumes
{
    public class Resume
    {
        public string _name = "";
        public List<Job> _jobs = new();
        public void DisplayResume()
        {   Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {   
               job.GetJob();
            }
        }
    }

}