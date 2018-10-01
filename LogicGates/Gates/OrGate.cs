using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Gates
{
    public class OrGate : LogicGate
    {
        public OrGate(IEnumerable<Signal> inputs, Signal output) : base(inputs, output)
        {
        }

        protected override bool GateFunction() =>
            Inputs.Any(signal => signal.Value);
    }
}
