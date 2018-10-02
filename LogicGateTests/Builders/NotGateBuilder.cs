using LogicGates;
using LogicGates.Abstractions;

namespace LogicGateTests.Builders
{
    internal class NotGateBuilder
    {
        private IHaveOutput _input;

        public NotGateBuilder WithInput(IHaveOutput input)
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
