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
                .WithInput(notGate)
                .WithInput(orGate)
                .Build();

            Assert.True(andGate.State());
        }

        [Fact]
        //  can be removed; just trying out stuff
        public void BasicComposite_NoBuilders()
        {
            var notGate = new NotGate();
            notGate.AddInput(new Signal(false));

            var orGate = new OrGate();
            orGate.AddInput(new Signal(false));
            orGate.AddInput(new Signal(true));

            var andGate = new AndGate();
            andGate.AddInput(notGate);
            andGate.AddInput(orGate);

            Assert.True(andGate.State());
        }

        [Fact]
        public void MediumCompositeCircut()
        {
            var notGate1 = NotGateBuilder
                .WithInput(new Signal(false))
                .Build();

            var notGate2 = NotGateBuilder
                .WithInput(new Signal(true))
                .Build();

            var andGate = AndGateBuilder
                .WithInput(notGate1)
                .WithInput(notGate2)
                .Build();

            var notGate3 = NotGateBuilder
                .WithInput(andGate)
                .Build();

            var orGate = OrGateBuilder
                .WithInput(new Signal(false))
                .WithInput(notGate3)
                .Build();

            Assert.True(orGate.State());
        }
    }
}
