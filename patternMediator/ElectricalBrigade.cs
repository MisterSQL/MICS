using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternMediator
{
    class ElectricalBrigade : Brigade
    {
        // Constructor for ElectricalBrigade, initializing it with a name and specifying its specialization as "electrics."
        public ElectricalBrigade(string name) : base(name, "електрика") { }
    }
}
