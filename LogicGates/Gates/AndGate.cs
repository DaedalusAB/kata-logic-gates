using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Gates
{
    public class AndGate
    {
        public IEnumerable<Signal> Inputs { get; set; }

        public AndGate(IEnumerable<Signal> inputs)
        {
            Inputs = inputs;
        }

        public Signal Trigger()
        {
            return Inputs.All(signal => signal.Value)
                ? new Signal(true)
                : new Signal(false);
        }
    }
}
