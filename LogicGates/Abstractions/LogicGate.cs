using System.Collections.Generic;

namespace LogicGates.Abstractions
{
    public abstract class LogicGate : IOutputState, IHaveInputs
    {
        protected Signal Output { get; }
        protected List<IOutputState> Inputs { get; set; }

        protected LogicGate()
        {
            Output = new Signal();
            Inputs = new List<IOutputState>();
        }

        public void AddInput(IOutputState input) =>
            Inputs.Add(input);

        public abstract bool State();
    }
}
