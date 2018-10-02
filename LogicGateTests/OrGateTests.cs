using Xunit;

using LogicGates;
using LogicGateTests.Builders;

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
                    new Signal(false),
                    new Signal(false),
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
                    new Signal(false),
                    new Signal(true),
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
                    new Signal(true),
                    new Signal(true),
                })
                .Build();

            Assert.True(orGate.State());
        }
    }
}
