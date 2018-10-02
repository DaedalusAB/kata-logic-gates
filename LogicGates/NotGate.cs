using System.Linq;

namespace LogicGates
{
    public class NotGate : LogicGate
    {
        public NotGate(Signal output) : base(output)
        {
        }

        public override bool State()
        {
            Output.SetState(!Inputs.First().State());
            return Output.State();
        }
    }
}
