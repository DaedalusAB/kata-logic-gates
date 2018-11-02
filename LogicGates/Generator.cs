namespace LogicGates.Factory
{
    public class Generator : IOutput
    {
        private readonly bool _value;

        public Generator(bool value)
        {
            _value = value;
        }

        public bool Output() =>
            _value;
    }
}