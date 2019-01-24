namespace LogicGates
{
    public class Generator : IOutput
    {
        public static Generator ActiveGenerator() => new Generator(true);
        public static Generator InactiveGenerator() => new Generator(false);

        private readonly bool _value;

        public Generator(bool value)
        {
            _value = value;
        }

        public bool Output() =>
            _value;
    }
}