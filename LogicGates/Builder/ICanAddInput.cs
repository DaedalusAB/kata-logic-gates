namespace LogicGates.Builder
{
    public interface ICanAddInput : IBuildGates
    {
        ICanAddInput AddInput(IOutput input);
    }
}