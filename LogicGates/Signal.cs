namespace LogicGates
{
    public class Signal
    {
        public bool Value { get; private set; }

        public Signal(bool value = false)
        {
            Value = value;
        }

        public void Activate()
        {
            Value = true;
        }

        public void Deactivate()
        {
            Value = false;
        }
    }
}