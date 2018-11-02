using LogicGates;
using LogicGates.Builders;
using Xunit;

namespace LogicGateTests
{
    public class NotGateTests
    {
        private readonly NotGateBuilder NotGateBuilder = new NotGateBuilder();

        [Fact]
        public void Zero_Negated_Is_One()
        {
            var notGate = NotGateBuilder
                .WithInput(
                    Generator.AnInactiveSignal()
                )
                .Build();

            Assert.True(notGate.Output());
        }

        [Fact]
        public void One_Negated_Is_Zero()
        {
            var notGate = NotGateBuilder
                .WithInput(
                    Generator.AnActiveSignal()
                )
                .Build();

            Assert.False(notGate.Output());
        }
    }
}
