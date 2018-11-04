using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class NotGate : IHaveOutput
    {
        private IHaveOutput Input { get; set; }

        public bool Output() =>
            !Input.Output();

        public void SetInput(IHaveOutput input) =>
            Input = input;
    }
}