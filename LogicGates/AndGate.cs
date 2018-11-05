using LogicGates.Strategy;

namespace LogicGates
{
    public class AndGate : LogicGate
    {
        public AndGate() : base(new AndFunction())
        {
        }
    }
}
