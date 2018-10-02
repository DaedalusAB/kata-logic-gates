using System.Linq;
using LogicGates.Abstractions;

namespace LogicGates
{
    public class AndGate : LogicGate
    {
        public override bool OutputValue()
        {
            Output.SetState(Inputs.All(signal => signal.OutputValue()));
            return Output.OutputValue();
        }
    }
}
