using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Gates
{
    public abstract class LogicGate
    {
        public void Emit() => 
            Output.Value = GateFunction();

        public bool State() =>
            Output.Value;

        protected Signal Output { get; }
        protected List<Signal> Inputs { get; }

        protected LogicGate(IEnumerable<Signal> inputs, Signal output)
        {
            Output = output;
            Inputs = inputs.ToList();
        }

        protected abstract bool GateFunction();
    }
}
