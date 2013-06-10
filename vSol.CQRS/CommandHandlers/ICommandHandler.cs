using vSol.CQRS.CommandResults;
using vSol.CQRS.Commands;

namespace vSol.CQRS.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        CommandResult Execute(TCommand command);
    }
}
