using System.Collections.Generic;
using System.Linq;
using LogicGates.Abstractions;

namespace LogicGates
{
    public class NotGate : LogicGate
    {
        public override bool State()
        {
            Output.SetState(!Inputs.First().State());
            return Output.State();
        }

        public new void AddInput(IOutputState input)
        {
            Inputs = new List<IOutputState>() { input };
        }
    }
}