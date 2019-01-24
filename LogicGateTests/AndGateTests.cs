using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class AndGateTests
    {
        [Fact]
        public void Zero_And_Zero_Is_Zero()
        {
            var andGate = LogicGate.AndGate();
            andGate.AddInput(Generator.InactiveGenerator());
            andGate.AddInput(Generator.InactiveGenerator());

            Assert.False(andGate.Output());
        }

        [Fact]
        public void Zero_And_One_Is_Zero()
        {
            var andGate = LogicGate.AndGate();
            andGate.AddInput(Generator.ActiveGenerator());
            andGate.AddInput(Generator.InactiveGenerator());

            Assert.False(andGate.Output());
        }

        [Fact]
        public void One_And_One_Is_One()
        {

            var andGate = LogicGate.AndGate();
            andGate.AddInput(Generator.ActiveGenerator());
            andGate.AddInput(Generator.ActiveGenerator());

            Assert.True(andGate.Output());
        }
    }
}
