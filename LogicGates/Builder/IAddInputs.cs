namespace LogicGates.Builder
{
    public interface IAddInputs : IBuildGates
    {
        IAddInputs AddInput(IOutput input);
    }
}