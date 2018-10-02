using LogicGates.Abstractions;

namespace LogicGates
{
    public class Signal : IHaveOutput
    {
        public static Signal AnActiveSignal() => new Signal(true);
        public static Signal AnInactiveSignal() => new Signal(false);

        private readonly bool _value;

        public Signal(bool value)
        {
            _value = value;
        }

        public bool Output() => _value;
    }
}