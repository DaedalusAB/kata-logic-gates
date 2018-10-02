namespace LogicGates
{
    public class Signal : IStateful
    {
        private bool _value;

        public Signal(bool value = false)
        {
            _value = value;
        }

        public bool State() => _value;

        public void SetState(bool state) => _value = state;
    }
}