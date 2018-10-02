using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class XorGateTests
    {
        private readonly XorGateBuilder XorGateBuilder = new XorGateBuilder();

        [Fact]
        public void Zero_Xor_Zero_Is_Zero()
        {
            var xorGate = XorGateBuilder
                .WithInput(Signal.AnInactiveSignal())
                .WithInput(Signal.AnInactiveSignal())
                .Build();

            Assert.False(xorGate.Output());
        }

        [Fact]
        public void Zero_Xor_Zero_Xor_One_Is_One()
        {

            var xorGate = XorGateBuilder
                .WithInput(Signal.AnInactiveSignal())
                .WithInput(Signal.AnInactiveSignal())
                .WithInput(Signal.AnActiveSignal())
                .Build();

            Assert.True(xorGate.Output());
        }

        [Fact]
        public void One_Xor_One_Xor_Zero_Is_Zero()
        {
            var xorGate = XorGateBuilder
                .WithInput(Signal.AnActiveSignal())
                .WithInput(Signal.AnActiveSignal())
                .WithInput(Signal.AnInactiveSignal())
                .Build();

            Assert.False(xorGate.Output());
        }
    }
}
