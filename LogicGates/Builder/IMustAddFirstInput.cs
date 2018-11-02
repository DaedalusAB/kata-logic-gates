using LogicGates.Factory;

namespace LogicGates.Builder
{
    public interface IMustAddFirstInput
    {
        IMustAddSecondInput AddFirstInput(IOutput input);
    }
}