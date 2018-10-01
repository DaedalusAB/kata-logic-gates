namespace LogicGates.Gates
{
    public class NotGate : ILogicGate
    {
        private Signal Input;
        private Signal Output;

        public NotGate(Signal input, Signal output)
        {
            Input = input;
            Output = output;
        }


        public void Trigger()
        {
           if(Input.Value) 
               Output.Deactivate();
            else
               Output.Activate();
        }

        public bool State() =>
            Output.Value;
    }
}
