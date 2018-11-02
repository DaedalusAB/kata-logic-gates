using System.Linq;

namespace LogicGates.Factory
{
    public static class LogicElementFactory
    {
        public static LogicGate AndGate() =>
            new LogicGate(inputs => inputs.All(input => input.Output()));

        public static LogicGate OrGate() =>
            new LogicGate(inputs => inputs.Any(input => input.Output()));

        public static LogicGate XorGate() =>
            new LogicGate(inputs => inputs.Count(input => input.Output()) % 2 == 1);

        public static UrnaryLogicGate NotGate() =>
            new UrnaryLogicGate(input => !input.Output());

        public static Generator ActiveGenerator() =>
            new Generator(true);

        public static Generator InactiveGenerator() =>
            new Generator(false);
    }
}
