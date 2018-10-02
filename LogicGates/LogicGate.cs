using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public abstract class LogicGate
    {
        protected Signal Output { get; }
        protected List<IConnectable> Inputs { get; }

        protected LogicGate(IEnumerable<IConnectable> inputs, Signal output)
        {
            Output = output;
            Inputs = inputs.ToList();
        }
        public abstract void Emit();

        public bool State() =>
            Output.State();
    }
}
