using LogicGates.Abstractions;
using System.Linq;

namespace LogicGates
{
    public class OrGate : LogicGate
    {
        public override bool OutputValue() =>
            Inputs.Any(signal => signal.OutputValue());
    }
}
