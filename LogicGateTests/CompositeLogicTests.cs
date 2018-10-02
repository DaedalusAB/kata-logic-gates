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
                .WithInput(Signal.AnInactiveSignal())
                .Build();

            var orGate = OrGateBuilder
                .WithInput(Signal.AnInactiveSignal())
                .WithInput(Signal.AnActiveSignal())
                .Build();

            var andGate = AndGateBuilder
                .WithInput(notGate)
                .WithInput(orGate)
                .Build();

            Assert.True(andGate.Output());
        }

        [Fact]
        //  can be removed; just trying out stuff
        public void BasicComposite_NoBuilders()
        {
            var notGate = new NotGate();
            notGate.AddInput(Signal.AnInactiveSignal());

            var orGate = new OrGate();
            orGate.AddInput(Signal.AnInactiveSignal());
            orGate.AddInput(Signal.AnActiveSignal());

            var andGate = new AndGate();
            andGate.AddInput(notGate);
            andGate.AddInput(orGate);

            Assert.True(andGate.Output());
        }

        [Fact]
        public void MediumCompositeCircut()
        {
            var notGate1 = NotGateBuilder
                .WithInput(Signal.AnInactiveSignal())
                .Build();

            var notGate2 = NotGateBuilder
                .WithInput(Signal.AnActiveSignal())
                .Build();

            var andGate = AndGateBuilder
                .WithInput(notGate1)
                .WithInput(notGate2)
                .Build();

            var notGate3 = NotGateBuilder
                .WithInput(andGate)
                .Build();

            var orGate = OrGateBuilder
                .WithInput(Signal.AnInactiveSignal())
                .WithInput(notGate3)
                .Build();

            Assert.True(orGate.Output());
        }
    }
}
