using vSol.CQRS.Commands;
using vSol.CQRS.CommandHandlers;

namespace vSol.CQRS.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
