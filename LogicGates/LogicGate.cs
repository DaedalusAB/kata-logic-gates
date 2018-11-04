﻿using System.Collections.Generic;

namespace LogicGates
{
    public abstract class LogicGate : IHaveOutput
    {
        protected List<IHaveOutput> Inputs { get; set; } = new List<IHaveOutput>();

        public void AddInput(IHaveOutput input) =>
            Inputs.Add(input);

        public abstract bool Output();
    }
}
