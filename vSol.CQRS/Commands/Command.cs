﻿using System;

namespace vSol.CQRS.Commands
{
    [Serializable]
    public class Command : ICommand
    {
        public Guid Id { get; private set; }
        public int Version { get; private set; }
        public Command(Guid id, int version)
        {
            Id = id;
            Version = version;
        }
    }
}