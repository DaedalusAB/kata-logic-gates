using LogicGates;
using Xunit;
using LogicGateTests.Builders;

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
                    new Signal(false),
                    new Signal(false),
                })
                .Build();

            Assert.False(andGate.State());
        }

        [Fact]
        public void Zero_And_One_Is_Zero()
        {
            var andGate = AndGateBuilder
                .WithInputs(new[]
                {
                    new Signal(false),
                    new Signal(true),
                })
                .Build();

            Assert.False(andGate.State());
        }

        [Fact]
        public void One_And_One_Is_One()
        {
            var andGate = AndGateBuilder
                .WithInputs(new[]
                {
                    new Signal(true),
                    new Signal(true),
                })
                .Build();

            Assert.True(andGate.State());
        }
    }
}
