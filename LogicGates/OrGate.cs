﻿using LogicGates.Abstractions;
using System.Linq;

namespace LogicGates
{
    public class OrGate : LogicGate
    {
        public override bool Output() =>
            Inputs.Any(signal => signal.Output());
    }
}
