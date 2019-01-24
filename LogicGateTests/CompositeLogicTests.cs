using LogicGates;
using Xunit;

namespace LogicGateTests
{
    public class CompositeLogicTests
    {
        [Fact]
        public void BasicCompositeCircut_WithImpliedBuilder()
        {
            var circut =
                LogicGate.AndGate()
                    .AddInput(UrnaryLogicGate.NotGate()
                        .SetInput(Generator.InactiveGenerator()))
                    .AddInput(LogicGate.OrGate()
                        .AddInput(Generator.InactiveGenerator())
                        .AddInput(Generator.ActiveGenerator()));

            Assert.True(circut.Output());
        }

        [Fact]
        public void BasicCompositeCircuit()
        {
            var notGate = UrnaryLogicGate.NotGate();
            notGate.SetInput(Generator.InactiveGenerator());

            var orGate = LogicGate.OrGate();
            orGate.AddInput(Generator.InactiveGenerator());
            orGate.AddInput(Generator.ActiveGenerator());

            var andGate = LogicGate.AndGate();
            andGate.AddInput(notGate);
            andGate.AddInput(orGate);

            Assert.True(andGate.Output());
        }

        [Fact]
        public void MediumCompositeCircut()
        {
            var notGate1 = UrnaryLogicGate.NotGate();
            notGate1.SetInput(Generator.InactiveGenerator());

            var notGate2 = UrnaryLogicGate.NotGate();
            notGate2.SetInput(Generator.ActiveGenerator());

            var andGate = LogicGate.AndGate();
            andGate.AddInput(notGate1);
            andGate.AddInput(notGate2);

            var notGate3 = UrnaryLogicGate.NotGate();
            notGate3.SetInput(andGate);

            var orGate = LogicGate.OrGate();
            orGate.AddInput(notGate3);
            orGate.AddInput(Generator.InactiveGenerator());

            Assert.True(orGate.Output());
        }
    }
}
