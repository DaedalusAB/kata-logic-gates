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
                .WithInputs(new[]
                {
                    Signal.AnInactiveSignal(),
                    Signal.AnInactiveSignal()
                })
                .Build();

            Assert.False(andGate.Output());
        }

        [Fact]
        public void Zero_And_One_Is_Zero()
        {
            var andGate = AndGateBuilder
                .WithInputs(new[]
                {
                    Signal.AnActiveSignal(),
                    Signal.AnInactiveSignal()
                })
                .Build();

            Assert.False(andGate.Output());
        }

        [Fact]
        public void One_And_One_Is_One()
        {
            var andGate = AndGateBuilder
                .WithInputs(new[]
                {
                    Signal.AnActiveSignal(),
                    Signal.AnActiveSignal()
                })
                .Build();

            Assert.True(andGate.Output());
        }
    }
}
