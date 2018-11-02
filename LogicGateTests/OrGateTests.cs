using LogicGates;
using LogicGateTests.Builders;
using Xunit;

namespace LogicGateTests
{
    public class OrGateTests
    {
        private readonly OrGateBuilder OrGateBuilder = new OrGateBuilder();

        [Fact]
        public void Zero_Or_Zero_Is_Zero()
        {
            var orGate = OrGateBuilder
                .WithInput(Generator.AnInactiveSignal())
                .WithInput(Generator.AnInactiveSignal())
                .Build();

            Assert.False(orGate.Output());
        }

        [Fact]
        public void Zero_Or_One_Is_One()
        {
            var orGate = OrGateBuilder
                .WithInput(Generator.AnInactiveSignal())
                .WithInput(Generator.AnActiveSignal())
                .Build();

            Assert.True(orGate.Output());
        }

        [Fact]
        public void One_Or_One_Is_One()
        {
            var orGate = OrGateBuilder
                .WithInput(Generator.AnActiveSignal())
                .WithInput(Generator.AnActiveSignal())
                .Build();

            Assert.True(orGate.Output());
        }
    }
}
