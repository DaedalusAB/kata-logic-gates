using LogicGates.Builder;
using LogicGates.Factory;
using Xunit;

namespace LogicGateTests
{
    public class CompositeLogicTests
    {
        [Fact]
        public void BasicCompositeCircut_WithBuilder()
        {
            var logic = new LogicBuilder()
                .AndGate()
                .AddFirstInput(
                    new LogicBuilder()
                        .OrGate()
                        .AddFirstInput(new LogicBuilder().ActiveGenerator().Build())
                        .AddSecondInput(new LogicBuilder().InactiveGenerator().Build())
                        .Build()
                )
                .AddSecondInput(
                    new LogicBuilder()
                        .NotGate()
                        .SetInput(new LogicBuilder().InactiveGenerator().Build())
                        .Build())
                .Build();

            Assert.True(logic.Output());
        }

        [Fact]
        public void BasicCompositeCircuit()
        {
            var notGate = LogicElementFactory.NotGate();
            notGate.SetInput(LogicElementFactory.InactiveGenerator());

            var orGate = LogicElementFactory.OrGate();
            orGate.AddInput(LogicElementFactory.InactiveGenerator());
            orGate.AddInput(LogicElementFactory.ActiveGenerator());

            var andGate = LogicElementFactory.AndGate();
            andGate.AddInput(notGate);
            andGate.AddInput(orGate);

            Assert.True(andGate.Output());
        }

        [Fact]
        public void MediumCompositeCircut()
        {
            var notGate1 = LogicElementFactory.NotGate();
            notGate1.SetInput(LogicElementFactory.InactiveGenerator());

            var notGate2 = LogicElementFactory.NotGate();
            notGate2.SetInput(LogicElementFactory.ActiveGenerator());

            var andGate = LogicElementFactory.AndGate();
            andGate.AddInput(notGate1);
            andGate.AddInput(notGate2);

            var notGate3 = LogicElementFactory.NotGate();
            notGate3.SetInput(andGate);

            var orGate = LogicElementFactory.OrGate();
            orGate.AddInput(notGate3);
            orGate.AddInput(LogicElementFactory.InactiveGenerator());

            Assert.True(orGate.Output());
        }
    }
}
