using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class AndGateTests
    {

        [Fact]
        public void Zero_And_Zero_Is_Zero()
        {
            var andGate = LogicGateFactory.AndGate();
            andGate.AddInput(Generator.AnInactiveSignal());
            andGate.AddInput(Generator.AnInactiveSignal());

            Assert.False(andGate.Output());
        }

        [Fact]
        public void Zero_And_One_Is_Zero()
        {
            var andGate = LogicGateFactory.AndGate();
            andGate.AddInput(Generator.AnActiveSignal());
            andGate.AddInput(Generator.AnInactiveSignal());

            Assert.False(andGate.Output());
        }

        [Fact]
        public void One_And_One_Is_One()
        {

            var andGate = LogicGateFactory.AndGate();
            andGate.AddInput(Generator.AnActiveSignal());
            andGate.AddInput(Generator.AnActiveSignal());

            Assert.True(andGate.Output());
        }
    }
}
