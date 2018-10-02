using System.Collections.Generic;
using System.Linq;
using LogicGates.Abstractions;

namespace LogicGates
{
    public class OrGate : LogicGate
    {
        public override bool OutputValue()
        {
            Output.SetState(Inputs.Any(signal => signal.OutputValue()));
            return Output.OutputValue();
        }
    }
}
