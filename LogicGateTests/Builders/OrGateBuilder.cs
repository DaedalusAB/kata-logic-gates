using System.Collections.Generic;
using System.Linq;
using LogicGates;
using LogicGates.Abstractions;

namespace LogicGateTests.Builders
{
    internal class OrGateBuilder
    {
        private readonly List<IHaveOutput> _inputs = new List<IHaveOutput>();

        public OrGateBuilder WithInputs(IEnumerable<IHaveOutput> inputs)
        {
            _inputs.AddRange(inputs.ToList());
            return this;
        }

        public OrGateBuilder WithInput(IHaveOutput input)
        {
            _inputs.Add(input);
            return this;
        }

        public OrGate Build()
        {
            var gate = new OrGate();
            foreach (var input in _inputs)
            {
                gate.AddInput(input);
            }

            return gate;
        }
    }
}