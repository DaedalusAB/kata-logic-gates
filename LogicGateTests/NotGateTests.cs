﻿using System;
using System.Collections.Generic;
using System.Text;
using LogicGates;
using LogicGateTests.Builders;
using Xunit;

namespace LogicGateTests
{
    public class NotGateTests
    {
        private readonly NotGateBuilder NotGateBuilder = new NotGateBuilder();

        [Fact]
        public void Zero_Negated_Is_One()
        {
            var output = new Signal();
            var notGate = NotGateBuilder
                .WithInput(
                    new Signal(false)
                )
                .WithOutput(output)
                .Build();

            notGate.Trigger();

            Assert.True(notGate.State());
        }

        [Fact]
        public void One_Negated_Is_Zero()
        {
            var output = new Signal();
            var notGate = NotGateBuilder
                .WithInput(
                    new Signal(true)
                )
                .WithOutput(output)
                .Build();

            notGate.Trigger();

            Assert.False(notGate.State());
        }
    }
}