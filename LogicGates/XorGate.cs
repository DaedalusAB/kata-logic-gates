using LogicGates.Strategy;

namespace LogicGates
{
    public class XorGate : LogicGate
    {
        public XorGate() : base(new XorFunction())
        {
        }
    }
}
