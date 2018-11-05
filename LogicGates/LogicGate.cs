using System;
using System.Collections.Generic;
using LogicGates.Factory;

namespace LogicGates
{
    public class LogicGate : IOutput
    {
        private List<IOutput> Inputs { get; }
        private Func<IEnumerable<IOutput>, bool> Logic { get; }

        public LogicGate(Func<IEnumerable<IOutput>, bool> logic)
        {
            Inputs = new List<IOutput>();
            Logic = logic;
        }
        
        public void AddInput(IOutput input) =>
            Inputs.Add(input);

        public bool Output() =>
            Logic(Inputs);
    }
}
