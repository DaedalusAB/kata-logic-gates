namespace LogicGates
{
    public class Signal
    {
        public bool Value { get; set; }

        public Signal(bool value = false)
        {
            Value = value;
        }
    }
}