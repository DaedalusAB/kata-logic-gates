using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public abstract class LogicGate : IConnectable
    {
        protected Signal Output { get; }
        protected List<IConnectable> Inputs { get; }

        protected LogicGate(Signal output)
        {
            Output = output;
            Inputs = new List<IConnectable>();
        }

        public abstract void Emit();

        public void AddInput(IConnectable input) =>
            Inputs.Add(input);

        public bool State() =>
            Output.State();
    }
}
