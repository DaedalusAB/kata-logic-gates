using LogicGates;

namespace LogicGateTests.Builders
{
    internal class NotGateBuilder
    {
        private Signal _input;
        private Signal _output;

        public NotGateBuilder WithInput(Signal input)
        {
            _input = input;
            return this;
        }

        public NotGateBuilder WithOutput(Signal output)
        {
            _output = output;
            return this;
        }

        public NotGate Build()
        {
            return new NotGate(_input, _output);
        }
    }
}
