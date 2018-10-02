using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class NotGateTests
    {

        [Fact]
        public void Zero_Negated_Is_One()
        {
            var notGate = LogicGateFactory.NotGate();
            notGate.AddInput(Generator.AnInactiveSignal());

            Assert.True(notGate.Output());
        }

        [Fact]
        public void One_Negated_Is_Zero()
        {

            var notGate = LogicGateFactory.NotGate();
            notGate.AddInput(Generator.AnActiveSignal());

            Assert.False(notGate.Output());
        }
    }
}
