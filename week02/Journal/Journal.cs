using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journal;

public class Journal
{
    public List<string> Entries { get; set; } = new();
    public string Name { get; set; }
}
