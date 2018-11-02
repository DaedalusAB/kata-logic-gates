using System.Collections.Generic;

namespace LogicGates.Abstractions
{
    public abstract class LogicGate : IHaveOutput
    {
        protected List<IHaveOutput> Inputs { get; set; }

        protected LogicGate()
        {
            Inputs = new List<IHaveOutput>();
        }

        public void AddInput(IHaveOutput input) =>
            Inputs.Add(input);

        public abstract bool Output();
    }
}
