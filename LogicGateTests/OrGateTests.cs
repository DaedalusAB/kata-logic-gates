using LogicGates;
using LogicGateTests.Builders;
using Xunit;

namespace LogicGateTests
{
    public class OrGateTests
    {
        private readonly OrGateBuilder OrGateBuilder = new OrGateBuilder();

        [Fact]
        public void Zero_And_Zero_Is_Zero()
        {
            var orGate = OrGateBuilder
                .WithInputs(new[]
                {
                    Signal.AnInactiveSignal(),
                    Signal.AnInactiveSignal()
                })
                .Build();

            Assert.False(orGate.State());
        }

        [Fact]
        public void Zero_And_One_Is_One()
        {
            var orGate = OrGateBuilder
                .WithInputs(new[]
                {
                    Signal.AnInactiveSignal(),
                    Signal.AnActiveSignal()
                })
                .Build();

            Assert.True(orGate.State());
        }

        [Fact]
        public void One_And_One_Is_One()
        {
            var orGate = OrGateBuilder
                .WithInputs(new[]
                {
                    Signal.AnActiveSignal(),
                    Signal.AnActiveSignal()
                })
                .Build();

            Assert.True(orGate.State());
        }
    }
}
