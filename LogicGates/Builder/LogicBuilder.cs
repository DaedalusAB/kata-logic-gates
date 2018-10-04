namespace LogicGates.Builder
{
    public class LogicBuilder : IAddInputs, ISetAnInput, IBuildGates
    {
        private IOutput _logicElement;
        
        public IAddInputs AndGate()
        {
            _logicElement = LogicElementFactory.AndGate();
            return this;
        }

        public IAddInputs OrGate()
        {
            _logicElement = LogicElementFactory.OrGate();
            return this;
        }

        public IAddInputs XorGate()
        {
            _logicElement = LogicElementFactory.XorGate();
            return this;
        }

        public ISetAnInput NotGate()
        {
            _logicElement = LogicElementFactory.NotGate();
            return this;
        }

        public IBuildGates ActiveGenerator()
        {
            _logicElement = LogicElementFactory.ActiveGenerator();
            return this;
        }

        public IBuildGates InactiveGenerator()
        {
            _logicElement = LogicElementFactory.InactiveGenerator();
            return this;
        }

        public IAddInputs AddInput(IOutput input)
        {
            ((LogicGate)_logicElement).AddInput(input);
            return this;
        }

        public ISetAnInput SetInput(IOutput input)
        {
            ((UrnaryLogicGate)_logicElement).SetInput(input);
            return this;
        }

        public IOutput Build()
        {
            return _logicElement;
        }
    }
}
