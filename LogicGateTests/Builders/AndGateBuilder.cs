using LogicGates;

namespace LogicGateTests.Builders
{
    internal class AndGateBuilder
    {
        private IStateful[] _inputs;
        
        public AndGateBuilder WithInputs(IStateful[] inputs)
        {
            _inputs = inputs;
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
