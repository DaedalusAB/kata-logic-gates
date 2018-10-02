using LogicGates;

namespace LogicGateTests.Builders
{
    internal class NotGateBuilder
    {
        private IStateful _input;

        public NotGateBuilder WithInput(IStateful input)
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
