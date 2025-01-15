using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox
{
    public class House
    {
        public string _owner = "";
        public Blind _kitchenBlind = new();
        public Blind _loungeBlind = new();
    }
}