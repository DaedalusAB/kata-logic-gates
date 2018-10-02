using LogicGates.Abstractions;
using System.Linq;

namespace LogicGates
{
    public class AndGate : LogicGate
    {
        public override bool Output() =>
            Inputs.All(signal => signal.Output());
    }
}
