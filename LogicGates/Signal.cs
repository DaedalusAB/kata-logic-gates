﻿using LogicGates.Abstractions;

namespace LogicGates
{
    public class Signal : IOutputState
    {
        public static Signal AnActiveSignal() => new Signal(true);
        public static Signal AnInactiveSignal() => new Signal(false);

        private bool _value;

        public Signal(bool value = false)
        {
            _value = value;
        }

        public void SetState(bool state) => _value = state;

        public bool State() => _value;
    }
}