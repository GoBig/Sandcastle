using System;

namespace vSol.CQRS.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}