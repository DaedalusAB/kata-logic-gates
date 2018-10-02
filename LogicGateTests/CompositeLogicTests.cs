using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class CompositeLogicTests
    {
        [Fact]
        public void BasicCompositeCircuit()
        {
            var notGate = LogicGateFactory.NotGate();
            notGate.AddInput(Generator.AnInactiveSignal());

            var orGate = LogicGateFactory.OrGate();
            orGate.AddInput(Generator.AnInactiveSignal());
            orGate.AddInput(Generator.AnActiveSignal());

            var andGate = LogicGateFactory.AndGate();
            andGate.AddInput(notGate);
            andGate.AddInput(orGate);

            Assert.True(andGate.Output());
        }

        [Fact]
        public void MediumCompositeCircut()
        {
            var notGate1 = LogicGateFactory.NotGate();
            notGate1.AddInput(Generator.AnInactiveSignal());

            var notGate2 = LogicGateFactory.NotGate();
            notGate2.AddInput(Generator.AnActiveSignal());

            var andGate = LogicGateFactory.AndGate();
            andGate.AddInput(notGate1);
            andGate.AddInput(notGate2);

            var notGate3 = LogicGateFactory.NotGate();
            notGate3.AddInput(andGate);

            var orGate = LogicGateFactory.OrGate();
            orGate.AddInput(notGate3);
            orGate.AddInput(Generator.AnInactiveSignal());

            Assert.True(orGate.Output());
        }
    }
}
