using LogicGates;
using LogicGates.Gates;

namespace LogicGateTests.Builders
{
    class AndGateBuilder
    {
        private Signal[] _inputs;
        
        public AndGateBuilder WithInputs(Signal[] inputs)
        {
            _inputs = inputs;
            return this;
        }

        public AndGate Build()
        {
            var gate = new AndGate(_inputs);
            return gate;
        }
    }
}
