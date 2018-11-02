using System.Collections.Generic;

namespace LogicGates.Builders
{
    public class AndGateBuilder
    {
        private readonly List<IHaveOutput> _inputs = new List<IHaveOutput>();

        public AndGateBuilder WithInput(IHaveOutput input)
        {
            _inputs.Add(input);
            return this;
        }

        public AndGate Build()
        {
            var gate = new AndGate();
            foreach (var input in _inputs)
            {
                gate.AddInput(input);
            }

            return gate;
        }
    }
}
