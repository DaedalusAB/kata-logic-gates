using LogicGates.Strategy;

namespace LogicGates
{
    public class OrGate : LogicGate
    {
        public OrGate() : base(new OrFunction())
        {
        }
    }
}
