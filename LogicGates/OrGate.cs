using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class OrGate : LogicGate
    {
        public OrGate(IEnumerable<IConnectable> inputs, Signal output) : base(inputs, output)
        {
        }

        public override void Emit() =>
            Output.SetState(Inputs.Any(signal => signal.State()));
    }
}
