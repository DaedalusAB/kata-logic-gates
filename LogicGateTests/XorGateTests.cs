using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class XorGateTests
    {
        [Fact]
        public void Zero_Xor_Zero_Is_Zero()
        {
            var xorGate = LogicGateFactory.XorGate();
            xorGate.AddInput(Generator.AnInactiveSignal());
            xorGate.AddInput(Generator.AnInactiveSignal());

            Assert.False(xorGate.Output());
        }

        [Fact]
        public void Zero_Xor_Zero_Xor_One_Is_One()
        {
            var xorGate = LogicGateFactory.XorGate();
            xorGate.AddInput(Generator.AnInactiveSignal());
            xorGate.AddInput(Generator.AnInactiveSignal());
            xorGate.AddInput(Generator.AnActiveSignal());

            Assert.True(xorGate.Output());
        }

        [Fact]
        public void One_Xor_One_Xor_Zero_Is_Zero()
        {
            var xorGate = LogicGateFactory.XorGate();
            xorGate.AddInput(Generator.AnActiveSignal());
            xorGate.AddInput(Generator.AnActiveSignal());
            xorGate.AddInput(Generator.AnInactiveSignal());

            Assert.False(xorGate.Output());
        }
    }
}
