using LogicGates;
using LogicGates.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace LogicGateTests.Builders
{
    internal class AndGateBuilder
    {
        private readonly List<IHaveOutput> _inputs = new List<IHaveOutput>();

        public AndGateBuilder WithInputs(IEnumerable<IHaveOutput> inputs)
        {
            _inputs.AddRange(inputs.ToList());
            return this;
        }

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
