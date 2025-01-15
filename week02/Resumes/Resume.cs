using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resumes
{
    public class Resume
    {
        public string _name = "";
        public List<Job> _jobs {get; set;} = new();
    }
}