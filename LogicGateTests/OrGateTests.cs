using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class OrGateTests
    {
        [Fact]
        public void Zero_Or_Zero_Is_Zero()
        {
            var orGate = LogicGate.OrGate();
            orGate.AddInput(Generator.InactiveGenerator());
            orGate.AddInput(Generator.InactiveGenerator());

            Assert.False(orGate.Output());
        }

        [Fact]
        public void Zero_Or_One_Is_One()
        {
            var orGate = LogicGate.OrGate();
            orGate.AddInput(Generator.InactiveGenerator());
            orGate.AddInput(Generator.ActiveGenerator());

            Assert.True(orGate.Output());
        }

        [Fact]
        public void One_Or_One_Is_One()
        {

            var orGate = LogicGate.OrGate();
            orGate.AddInput(Generator.ActiveGenerator());
            orGate.AddInput(Generator.ActiveGenerator());

            Assert.True(orGate.Output());
        }
    }
}
