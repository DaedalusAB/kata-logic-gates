﻿using System.Collections.Generic;

namespace LogicGates.Builders
{
    public class XorGateBuilder
    {
        private readonly List<IHaveOutput> _inputs = new List<IHaveOutput>();

        public XorGateBuilder WithInput(IHaveOutput input)
        {
            _inputs.Add(input);
            return this;
        }

        public XorGate Build()
        {
            var gate = new XorGate();
            foreach (var input in _inputs)
            {
                gate.AddInput(input);
            }

            return gate;
        }
    }
}