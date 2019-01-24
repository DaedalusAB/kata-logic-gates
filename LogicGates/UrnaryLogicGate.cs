using System;

namespace LogicGates
{
    public class UrnaryLogicGate : IOutput
    {
        public static UrnaryLogicGate NotGate() => new UrnaryLogicGate(input => !input.Output());

        private IOutput Input { get; set; }
        private Func<IOutput, bool> Logic { get; }

        public UrnaryLogicGate(Func<IOutput, bool> logic)
        {
            Logic = logic;
        }

        public UrnaryLogicGate SetInput(IOutput input)
        {
            Input = input;
            return this;
        }

        public bool Output() =>
            Logic(Input);
    }
}
