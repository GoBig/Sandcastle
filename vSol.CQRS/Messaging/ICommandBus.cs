using vSol.CQRS.CommandResults;
using vSol.CQRS.Commands;

namespace vSol.CQRS.Messaging
{
    public interface ICommandBus
    {
        CommandResult Send<T>(T command) where T : Command;
    }    
}
