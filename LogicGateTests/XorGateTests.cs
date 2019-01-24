using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class XorGateTests
    {
        [Fact]
        public void Zero_Xor_Zero_Is_Zero()
        {
            var xorGate = LogicGate.XorGate();
            xorGate.AddInput(Generator.InactiveGenerator());
            xorGate.AddInput(Generator.InactiveGenerator());

            Assert.False(xorGate.Output());
        }

        [Fact]
        public void Zero_Xor_Zero_Xor_One_Is_One()
        {
            var xorGate = LogicGate.XorGate();
            xorGate.AddInput(Generator.InactiveGenerator());
            xorGate.AddInput(Generator.InactiveGenerator());
            xorGate.AddInput(Generator.ActiveGenerator());

            Assert.True(xorGate.Output());
        }

        [Fact]
        public void One_Xor_One_Xor_Zero_Is_Zero()
        {
            var xorGate = LogicGate.XorGate();
            xorGate.AddInput(Generator.ActiveGenerator());
            xorGate.AddInput(Generator.ActiveGenerator());
            xorGate.AddInput(Generator.InactiveGenerator());

            Assert.False(xorGate.Output());
        }
    }
}
