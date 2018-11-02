﻿using LogicGates.Factory;

namespace LogicGates.Builder
{
    public interface ISetAnInput : IBuildGates
    {
        ISetAnInput SetInput(IOutput input);
    }
}