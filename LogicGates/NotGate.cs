using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class NotGate : LogicGate
    {
        public override bool Output() =>
            !Inputs.First().Output();

        public new void AddInput(IHaveOutput input) =>
            Inputs = new List<IHaveOutput>() { input };
    }
}