using LogicGates;

namespace LogicGateTests.Builders
{
    internal class OrGateBuilder
    {
        private Signal[] _inputs;
        private Signal _output;

        public OrGateBuilder WithInputs(Signal[] inputs)
        {
            _inputs = inputs;
            return this;
        }

        public OrGateBuilder WithOutput(Signal output)
        {
            _output = output;
            return this;
        }

        public OrGate Build()
        {
            var gate = new OrGate(_output);
            foreach (var input in _inputs)
            {
                gate.AddInput(input);
            }

            return gate;
        }
    }
}