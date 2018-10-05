namespace LogicGates
{
    public class Generator : IOutput
    {
        public Generator(bool value)
        {
            Output = value;
        }

        public bool Output { get; }
    }
}