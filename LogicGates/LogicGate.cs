using LogicGates.Strategy;
using System.Collections.Generic;

namespace LogicGates
{
    public abstract class LogicGate : IHaveOutput
    {
        protected List<IHaveOutput> Inputs { get; set; } = new List<IHaveOutput>();
        protected LogicFunction Function { get; }

        protected LogicGate(LogicFunction function)
        {
            Function = function;
        }

        public void AddInput(IHaveOutput input) =>
            Inputs.Add(input);

        public bool Output() =>
            Function.Apply(Inputs);
    }
}
