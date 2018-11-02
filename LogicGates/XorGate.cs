using System.Linq;

namespace LogicGates
{
    public class XorGate : LogicGate
    {
        public override bool Output() =>
            Inputs.Count(input => input.Output()) % 2 == 1;
    }
}
