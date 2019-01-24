using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicGates
{
    public class LogicGate : IOutput
    {
        public static LogicGate AndGate() => new LogicGate(inputs => inputs.All(input => input.Output()));
        public static LogicGate OrGate() => new LogicGate(inputs => inputs.Any(input => input.Output()));
        public static LogicGate XorGate() => new LogicGate(inputs => inputs.Count(input => input.Output()) % 2 == 1);

        private List<IOutput> Inputs { get; }
        private Func<IEnumerable<IOutput>, bool> Logic { get; }

        public LogicGate(Func<IEnumerable<IOutput>, bool> logic)
        {
            Inputs = new List<IOutput>();
            Logic = logic;
        }

        public LogicGate AddInput(IOutput input)
        {
            Inputs.Add(input);
            return this;
        }

        public bool Output() =>
            Logic(Inputs);
    }
}
