using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resumes
{
    public class Job
    {
        public string _companyName = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;
        public void GetJob()
        {
            Console.WriteLine($"_jobTitle ({_companyName}) {_startYear}-{_endYear}");
        }
    }
}