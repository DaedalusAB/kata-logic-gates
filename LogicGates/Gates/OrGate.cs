using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Gates
{
    public class OrGate
    {
        public IEnumerable<Signal> Inputs { get; set; }

        public OrGate(IEnumerable<Signal> inputs)
        {
            Inputs = inputs;
        }

        public Signal Trigger()
        {
            return Inputs.Any(signal => signal.Value)
                ? new Signal(true)
                : new Signal(false);
        }
    }
}
