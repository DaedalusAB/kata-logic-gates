using LogicGates.Factory;
using Xunit;

namespace LogicGateTests
{
    public class AndGateTests
    {
        [Fact]
        public void Zero_And_Zero_Is_Zero()
        {
            var andGate = LogicElementFactory.AndGate();
            andGate.AddInput(LogicElementFactory.InactiveGenerator());
            andGate.AddInput(LogicElementFactory.InactiveGenerator());

            Assert.False(andGate.Output());
        }

        [Fact]
        public void Zero_And_One_Is_Zero()
        {
            var andGate = LogicElementFactory.AndGate();
            andGate.AddInput(LogicElementFactory.ActiveGenerator());
            andGate.AddInput(LogicElementFactory.InactiveGenerator());

            Assert.False(andGate.Output());
        }

        [Fact]
        public void One_And_One_Is_One()
        {

            var andGate = LogicElementFactory.AndGate();
            andGate.AddInput(LogicElementFactory.ActiveGenerator());
            andGate.AddInput(LogicElementFactory.ActiveGenerator());

            Assert.True(andGate.Output());
        }
    }
}
