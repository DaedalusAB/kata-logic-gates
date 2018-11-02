using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class NotGateTests
    {

        [Fact]
        public void Zero_Negated_Is_One()
        {
            var notGate = LogicElementFactory.NotGate();
            notGate.SetInput(LogicElementFactory.InactiveGenerator());

            Assert.True(notGate.Output());
        }

        [Fact]
        public void One_Negated_Is_Zero()
        {

            var notGate = LogicElementFactory.NotGate();
            notGate.SetInput(LogicElementFactory.ActiveGenerator());

            Assert.False(notGate.Output());
        }
    }
}
