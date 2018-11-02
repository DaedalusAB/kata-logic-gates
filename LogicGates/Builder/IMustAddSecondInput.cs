using LogicGates.Factory;

namespace LogicGates.Builder
{
    public interface IMustAddSecondInput
    {
        ICanAddInput AddSecondInput(IOutput input);
    }
}