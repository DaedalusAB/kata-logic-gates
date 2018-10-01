using System.Linq;

namespace LogicGates.Gates
{
    public class NotGate : LogicGate
    {
        public NotGate(Signal input, Signal output) : base(new[] { input }, output)
        {
        }

        protected override bool GateFunction() =>
            !Inputs.First().Value;
    }
}
