using LogicGates.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class NotGate : LogicGate
    {
        public override bool OutputValue() =>
            !Inputs.First().OutputValue();

        public new void AddInput(IHaveOutput input) =>
            Inputs = new List<IHaveOutput>() { input };
    }
}