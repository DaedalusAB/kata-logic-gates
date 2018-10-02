﻿using LogicGates.Abstractions;

namespace LogicGates
{
    public class Generator : IOutput
    {
        public static Generator AnActiveSignal() => new Generator(true);
        public static Generator AnInactiveSignal() => new Generator(false);

        private readonly bool _value;

        public Generator(bool value)
        {
            _value = value;
        }

        public bool Output() => _value;
    }
}