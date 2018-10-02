using LogicGates;
using LogicGateTests.Builders;
using Xunit;

namespace LogicGateTests
{
    public class CompositeLogicTests
    {
        private readonly AndGateBuilder AndGateBuilder = new AndGateBuilder();
        private readonly NotGateBuilder NotGateBuilder = new NotGateBuilder();
        private readonly OrGateBuilder OrGateBuilder = new OrGateBuilder();

        [Fact]
        public void BasicCompositeCircuit()
        {
            var notGate = NotGateBuilder
                .WithInput(new Signal(false))
                .Build();

            var orGate = OrGateBuilder
                .WithInputs(new[]
                {
                    new Signal(false),
                    new Signal(true)
                })
                .Build();

            var andGate = AndGateBuilder
                .WithInputs(new[]
                {
                    notGate.GetOutput(),
                    orGate.GetOutput()
                })
                .Build();

            Assert.True(andGate.State());
        }
    }
}
