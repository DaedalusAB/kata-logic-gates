using System.Collections.Generic;
using LogicGates.Abstractions;

namespace LogicGates
{
    public abstract class LogicGate : IStateful, IOutputState, IHaveInputs
    {
        protected Signal Output { get; }
        protected List<IStateful> Inputs { get; set; }

        protected LogicGate()
        {
            Output = new Signal();
            Inputs = new List<IStateful>();
        }

        public void AddInput(IStateful input) =>
            Inputs.Add(input);

        public abstract bool State();

        public IStateful GetOutput() =>
            this;
    }
}
