using LogicGates;
using LogicGates.Builder;
using Xunit;

namespace LogicGateTests
{
    public class CompositeLogicTests
    {
        private LogicBuilder LogicBuilder => new LogicBuilder();

        [Fact]
        public void BasicCompositeCircut_WithBuilder()
        {
            var logic = LogicBuilder
                .AndGate()
                .AddFirstInput(
                    LogicBuilder
                        .OrGate()
                        .AddFirstInput(LogicBuilder.ActiveGenerator().Build())
                        .AddSecondInput(LogicBuilder.InactiveGenerator().Build())
                        .Build()
                )
                .AddSecondInput(
                    LogicBuilder
                        .NotGate()
                        .SetInput(LogicBuilder.InactiveGenerator().Build())
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
