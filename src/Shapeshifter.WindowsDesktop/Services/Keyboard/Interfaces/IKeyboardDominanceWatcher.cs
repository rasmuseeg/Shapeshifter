﻿namespace Shapeshifter.WindowsDesktop.Services.Keyboard.Interfaces
{
    using System;

    using Infrastructure.Dependencies.Interfaces;

    public interface IKeyboardDominanceWatcher: ISingleInstance
    {
        void Start();
        void Stop();

        void Install();
    }
}