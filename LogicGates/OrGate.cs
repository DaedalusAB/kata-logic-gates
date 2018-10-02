using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class OrGate : LogicGate
    {
        public override bool State()
        {
            Output.SetState(Inputs.Any(signal => signal.State()));
            return Output.State();
        }
    }
}
