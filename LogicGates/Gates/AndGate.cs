using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Gates
{
    public class AndGate : LogicGate
    {
        public AndGate(IEnumerable<Signal> inputs, Signal output) : base(inputs, output)
        {
        }

        protected override bool GateFunction() =>
            Inputs.All(signal => signal.Value);
    }
}
