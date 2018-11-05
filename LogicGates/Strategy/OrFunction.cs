using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Strategy
{
    public class OrFunction : LogicFunction
    {
        public override bool Apply(IEnumerable<IHaveOutput> inputs) =>
            inputs.Any(i => i.Output());
    }
}