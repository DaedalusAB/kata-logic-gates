using LogicGates;

namespace LogicGateTests.Builders
{
    internal class OrGateBuilder
    {
        private IStateful[] _inputs;

        public OrGateBuilder WithInputs(IStateful[] inputs)
        {
            _inputs = inputs;
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