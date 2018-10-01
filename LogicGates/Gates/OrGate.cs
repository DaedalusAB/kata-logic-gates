using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Gates
{
    public class OrGate : ILogicGate
    {
        public IEnumerable<Signal> Inputs;
        public Signal Output;

        public OrGate(IEnumerable<Signal> inputs, Signal output)
        {
            Inputs = inputs;
            Output = output;
        }

        public void Trigger()
        {
            if (Inputs.Any(signal => signal.Value))
                Output.Activate();
            else
                Output.Deactivate();
        }

        public bool State() =>
            Output.Value;
    }
}
