using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class OrGate : LogicGate
    {
        public OrGate(Signal output) : base(output)
        {
        }

        public override void Emit() =>
            Output.SetState(Inputs.Any(signal => signal.State()));
    }
}
