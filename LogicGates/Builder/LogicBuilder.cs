namespace LogicGates.Builder
{
    public class LogicBuilder : IAddInputs, ISetAnInput, IBuildGates
    {
        private IOutput _logicElement;
        
        public IAddInputs AnAndGate()
        {
            _logicElement = LogicElementFactory.AndGate();
            return this;
        }

        public IAddInputs AnOrGate()
        {
            _logicElement = LogicElementFactory.OrGate();
            return this;
        }

        public IAddInputs AnXorGate()
        {
            _logicElement = LogicElementFactory.XorGate();
            return this;
        }

        public ISetAnInput ANotGate()
        {
            _logicElement = LogicElementFactory.NotGate();
            return this;
        }

        public IBuildGates AnActiveGenerator()
        {
            _logicElement = LogicElementFactory.ActiveGenerator();
            return this;
        }

        public IBuildGates AnInactiveGenerator()
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
