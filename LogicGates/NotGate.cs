using System.Collections.Generic;
using System.Linq;
using LogicGates.Abstractions;

namespace LogicGates
{
    public class NotGate : LogicGate
    {
        public override bool OutputValue()
        {
            Output.SetState(!Inputs.First().OutputValue());
            return Output.OutputValue();
        }

        public new void AddInput(IHaveOutput input)
        {
            Inputs = new List<IHaveOutput>() { input };
        }
    }
}