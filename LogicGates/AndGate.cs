using LogicGates.Abstractions;
using System.Linq;

namespace LogicGates
{
    public class AndGate : LogicGate
    {
        public override bool OutputValue() =>
            Inputs.All(signal => signal.OutputValue());
    }
}
