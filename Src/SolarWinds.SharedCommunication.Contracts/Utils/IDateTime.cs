﻿using System;

namespace SolarWinds.SharedCommunication.Contracts.Utils
{
    /// <summary>
    /// An interface for platform datetime.
    /// </summary>
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}