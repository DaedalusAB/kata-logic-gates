using LogicGates.Factory;

namespace LogicGates.Builder
{
    public class LogicBuilder : IMustAddFirstInput, IMustAddSecondInput, ICanAddInput, ISetAnInput
    {
        private IOutput _logicElement;
        
        public IMustAddFirstInput AndGate()
        {
            _logicElement = LogicElementFactory.AndGate();
            return this;
        }

        public IMustAddFirstInput OrGate()
        {
            _logicElement = LogicElementFactory.OrGate();
            return this;
        }

        public IMustAddFirstInput XorGate()
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

        public IMustAddSecondInput AddFirstInput(IOutput input)
        {
            ((LogicGate)_logicElement).AddInput(input);
            return this;
        }

        public ICanAddInput AddSecondInput(IOutput input)
        {
            ((LogicGate)_logicElement).AddInput(input);
            return this;
        }

        public ICanAddInput AddInput(IOutput input)
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
