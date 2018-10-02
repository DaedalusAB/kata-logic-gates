using LogicGates;

namespace LogicGateTests.Builders
{
    internal class AndGateBuilder
    {
        private Signal[] _inputs;
        private Signal _output;
        
        public AndGateBuilder WithInputs(Signal[] inputs)
        {
            _inputs = inputs;
            return this;
        }

        public AndGateBuilder WithOutput(Signal output)
        {
            _output = output;
            return this;
        }

        public AndGate Build()
        {
            var gate = new AndGate(_output);
            foreach (var input in _inputs)
            {
                gate.AddInput(input);
            }

            return gate;
        }
    }
}
