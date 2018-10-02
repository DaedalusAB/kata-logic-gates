using System.Collections.Generic;

namespace LogicGates.Abstractions
{
    public abstract class LogicGate : IHaveOutput, IHaveInputs
    {
        protected Signal Output { get; }
        protected List<IHaveOutput> Inputs { get; set; }

        protected LogicGate()
        {
            Output = new Signal();
            Inputs = new List<IHaveOutput>();
        }

        public void AddInput(IHaveOutput input) =>
            Inputs.Add(input);

        public abstract bool OutputValue();
    }
}
