using System.Linq;

namespace LogicGates
{
    public class AndGate : LogicGate
    {
        public override bool Output() =>
            Inputs.All(input => input.Output());
    }
}
