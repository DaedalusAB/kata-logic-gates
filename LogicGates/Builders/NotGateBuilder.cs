namespace LogicGates.Builders
{
    public class NotGateBuilder
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
            gate.SetInput(_input);

            return gate;
        }
    }
}
