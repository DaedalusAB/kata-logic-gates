using System.Collections.Generic;
using System.Linq;

namespace LogicGates.Strategy
{
    public class XorFunction : LogicFunction
    {
        public override bool Apply(IEnumerable<IHaveOutput> inputs) =>
            inputs.Count(i => i.Output()) % 2 == 1;
    }
}