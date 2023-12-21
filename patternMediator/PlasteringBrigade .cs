using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternMediator
{
    class PlasteringBrigade : Brigade
    {
        // Constructor for PlasteringBrigade, initializing it with a name and specifying its specialization as "plastering."
        public PlasteringBrigade(string name) : base(name, "штукатурка") { }
    }
}
