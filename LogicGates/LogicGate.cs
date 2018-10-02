using System.Collections.Generic;

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

        public void AddInput(IConnectable input) =>
            Inputs.Add(input);

        public abstract bool State();
    }
}
