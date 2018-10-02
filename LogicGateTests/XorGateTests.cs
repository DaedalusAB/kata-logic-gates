using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class XorGateTests
    {
        [Fact]
        public void Zero_Xor_Zero_Is_Zero()
        {
            var xorGate = LogicElementFactory.XorGate();
            xorGate.AddInput(LogicElementFactory.InactiveGenerator());
            xorGate.AddInput(LogicElementFactory.InactiveGenerator());

            Assert.False(xorGate.Output());
        }

        [Fact]
        public void Zero_Xor_Zero_Xor_One_Is_One()
        {
            var xorGate = LogicElementFactory.XorGate();
            xorGate.AddInput(LogicElementFactory.InactiveGenerator());
            xorGate.AddInput(LogicElementFactory.InactiveGenerator());
            xorGate.AddInput(LogicElementFactory.ActiveGenerator());

            Assert.True(xorGate.Output());
        }

        [Fact]
        public void One_Xor_One_Xor_Zero_Is_Zero()
        {
            var xorGate = LogicElementFactory.XorGate();
            xorGate.AddInput(LogicElementFactory.ActiveGenerator());
            xorGate.AddInput(LogicElementFactory.ActiveGenerator());
            xorGate.AddInput(LogicElementFactory.InactiveGenerator());

            Assert.False(xorGate.Output());
        }
    }
}
