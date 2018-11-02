using LogicGates.Factory;
using Xunit;

namespace LogicGateTests
{
    public class OrGateTests
    {
        [Fact]
        public void Zero_Or_Zero_Is_Zero()
        {
            var orGate = LogicElementFactory.OrGate();
            orGate.AddInput(LogicElementFactory.InactiveGenerator());
            orGate.AddInput(LogicElementFactory.InactiveGenerator());

            Assert.False(orGate.Output());
        }

        [Fact]
        public void Zero_Or_One_Is_One()
        {
            var orGate = LogicElementFactory.OrGate();
            orGate.AddInput(LogicElementFactory.InactiveGenerator());
            orGate.AddInput(LogicElementFactory.ActiveGenerator());

            Assert.True(orGate.Output());
        }

        [Fact]
        public void One_Or_One_Is_One()
        {

            var orGate = LogicElementFactory.OrGate();
            orGate.AddInput(LogicElementFactory.ActiveGenerator());
            orGate.AddInput(LogicElementFactory.ActiveGenerator());

            Assert.True(orGate.Output());
        }
    }
}
