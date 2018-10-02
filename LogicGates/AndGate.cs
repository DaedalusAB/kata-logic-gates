using System.Linq;
using LogicGates.Abstractions;

namespace LogicGates
{
    public class AndGate : LogicGate
    {
        public override bool State()
        {
            Output.SetState(Inputs.All(signal => signal.State()));
            return Output.State();
        }
    }
}
