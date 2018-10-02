using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class OrGateTests
    {
        [Fact]
        public void Zero_Or_Zero_Is_Zero()
        {
            var orGate = LogicGateFactory.OrGate();
            orGate.AddInput(Generator.AnInactiveSignal());
            orGate.AddInput(Generator.AnInactiveSignal());

            Assert.False(orGate.Output());
        }

        [Fact]
        public void Zero_Or_One_Is_One()
        {
            var orGate = LogicGateFactory.OrGate();
            orGate.AddInput(Generator.AnInactiveSignal());
            orGate.AddInput(Generator.AnActiveSignal());

            Assert.True(orGate.Output());
        }

        [Fact]
        public void One_Or_One_Is_One()
        {

            var orGate = LogicGateFactory.OrGate();
            orGate.AddInput(Generator.AnActiveSignal());
            orGate.AddInput(Generator.AnActiveSignal());

            Assert.True(orGate.Output());
        }
    }
}
