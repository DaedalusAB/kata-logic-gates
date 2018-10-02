using LogicGates.Abstractions;

namespace LogicGates
{
    public class Generator : IOutput
    {
        private bool Value { get; }

        public Generator(bool value)
        {
            Value = value;
        }

        public bool Output() =>
            Value;
    }
}