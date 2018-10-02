using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class AndGate : LogicGate
    {
        public AndGate(Signal output) : base(output)
        {
        }

        public override bool State()
        {
            Output.SetState(Inputs.All(signal => signal.State()));
            return Output.State();
        }
    }
}
