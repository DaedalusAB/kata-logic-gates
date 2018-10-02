using LogicGates;
using LogicGates.Abstractions;

namespace LogicGateTests.Builders
{
    internal class NotGateBuilder
    {
        private IOutputState _input;

        public NotGateBuilder WithInput(IOutputState input)
        {
            _input = input;
            return this;
        }

        public NotGate Build()
        {
            var gate = new NotGate();
            gate.AddInput(_input);

            return gate;
        }
    }
}
