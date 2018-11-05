using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Strategy
{
    public class AndFunction : LogicFunction
    {
        public override bool Apply(IEnumerable<IHaveOutput> inputs) =>
            inputs.All(i => i.Output());
    }
}