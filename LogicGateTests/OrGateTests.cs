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
            var output = new Signal();
            var orGate = OrGateBuilder
                .WithInputs(new[]
                {
                    new Signal(false),
                    new Signal(false),
                })
                .WithOutput(output)
                .Build();

            orGate.Emit();

            Assert.False(orGate.State);
        }

        [Fact]
        public void Zero_And_One_Is_One()
        {
            var output = new Signal();
            var orGate = OrGateBuilder
                .WithInputs(new[]
                {
                    new Signal(false),
                    new Signal(true),
                })
                .WithOutput(output)
                .Build();

            orGate.Emit();

            Assert.True(orGate.State);
        }

        [Fact]
        public void One_And_One_Is_One()
        {
            var output = new Signal();
            var orGate = OrGateBuilder
                .WithInputs(new[]
                {
                    new Signal(true),
                    new Signal(true),
                })
                .WithOutput(output)
                .Build();

            orGate.Emit();

            Assert.True(orGate.State);
        }
    }
}
