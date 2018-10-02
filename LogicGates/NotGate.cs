using System.Linq;

namespace LogicGates
{
    public class NotGate : LogicGate
    {
        public NotGate(IConnectable input, Signal output) : base(new[] { input }, output)
        {
        }

        public override void Emit() =>
            Output.SetState(!Inputs.First().State());
    }
}
