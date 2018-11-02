using LogicGates;
using LogicGateTests.Builders;
using Xunit;

namespace LogicGateTests
{
    public class AndGateTests
    {
        private readonly AndGateBuilder AndGateBuilder = new AndGateBuilder();

        [Fact]
        public void Zero_And_Zero_Is_Zero()
        {
            var andGate = AndGateBuilder
                .WithInput(Generator.AnInactiveSignal())
                .WithInput(Generator.AnInactiveSignal())
                .Build();

            Assert.False(andGate.Output());
        }

        [Fact]
        public void Zero_And_One_Is_Zero()
        {
            var andGate = AndGateBuilder
                .WithInput(Generator.AnActiveSignal())
                .WithInput(Generator.AnInactiveSignal())
                .Build();

            Assert.False(andGate.Output());
        }

        [Fact]
        public void One_And_One_Is_One()
        {
            var andGate = AndGateBuilder
                .WithInput(Generator.AnActiveSignal())
                .WithInput(Generator.AnActiveSignal())
                .Build();

            Assert.True(andGate.Output());
        }
    }
}
