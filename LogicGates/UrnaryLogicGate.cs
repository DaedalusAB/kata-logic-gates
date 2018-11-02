using System;

namespace LogicGates.Factory
{
    public class UrnaryLogicGate : IOutput
    {
        private IOutput Input { get; set; }
        private Func<IOutput, bool> Logic { get; }

        public UrnaryLogicGate(Func<IOutput, bool> logic)
        {
            Logic = logic;
        }

        public void SetInput(IOutput input) =>
            Input = input;

        public bool Output() =>
            Logic(Input);
    }
}
