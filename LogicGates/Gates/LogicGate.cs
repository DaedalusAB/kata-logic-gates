using System.Collections.Generic;

namespace LogicGates.Gates
{
    public abstract class LogicGate
    {
        public void Emit() => 
            Output.Value = GateFunction();

        public bool State =>
            Output.Value;

        protected Signal Output { get; }
        protected IEnumerable<Signal> Inputs { get; }

        protected LogicGate(IEnumerable<Signal> inputs, Signal output)
        {
            Output = output;
            Inputs = inputs;
        }

        protected abstract bool GateFunction();
    }
}
