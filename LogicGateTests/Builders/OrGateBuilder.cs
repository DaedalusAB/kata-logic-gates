using LogicGates;
using LogicGates.Gates;
using LogicGateTests.Builders;

namespace LogicGateTests
{
    internal class OrGateBuilder
    {
        private Signal[] _inputs;

        public OrGateBuilder WithInputs(Signal[] inputs)
        {
            _inputs = inputs;
            return this;
        }

        public OrGate Build()
        {
            var gate = new OrGate(_inputs);
            return gate;
        }
    }
}