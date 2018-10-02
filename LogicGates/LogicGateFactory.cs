using LogicGates.Abstractions;
using System.Linq;

namespace LogicGates
{
    public class LogicGateFactory
    {
        public static LogicGate AndGate() =>
            new LogicGate(inputs => inputs.All(input => input.Output()));
        public static LogicGate OrGate() =>
            new LogicGate(inputs => inputs.Any(input => input.Output()));
        public static LogicGate XorGate() =>
            new LogicGate(inputs => inputs.Count(input => input.Output()) % 2 == 1);
        public static LogicGate NotGate() =>
            new LogicGate(inputs => !inputs.First().Output());
    }
}
