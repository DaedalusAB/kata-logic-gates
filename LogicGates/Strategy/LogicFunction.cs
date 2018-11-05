using System.Collections.Generic;

namespace LogicGates.Strategy
{
    public abstract class LogicFunction
    {
        public abstract bool Apply(IEnumerable<IHaveOutput> inputs);
    }
}