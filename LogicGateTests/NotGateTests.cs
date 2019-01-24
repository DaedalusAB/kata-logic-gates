using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class NotGateTests
    {

        [Fact]
        public void Zero_Negated_Is_One()
        {
            var notGate = UrnaryLogicGate.NotGate();
            notGate.SetInput(Generator.InactiveGenerator());

            Assert.True(notGate.Output());
        }

        [Fact]
        public void One_Negated_Is_Zero()
        {

            var notGate = UrnaryLogicGate.NotGate();
            notGate.SetInput(Generator.ActiveGenerator());

            Assert.False(notGate.Output());
        }
    }
}
