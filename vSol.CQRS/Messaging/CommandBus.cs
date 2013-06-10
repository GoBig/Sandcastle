using vSol.CQRS.CommandResults;
using vSol.CQRS.Commands;
using vSol.CQRS.Exceptions;
using vSol.CQRS.Utils;

namespace vSol.CQRS.Messaging
{
    public class CommandBus : ICommandBus
    {
        private readonly ICommandHandlerFactory _commandHandlerFactory;

        public CommandBus(ICommandHandlerFactory commandHandlerFactory)
        {
            _commandHandlerFactory = commandHandlerFactory;
        }

        public CommandResult Send<T>(T command) where T : Command
        {
            var handler = _commandHandlerFactory.GetHandler<T>();
            
            if (handler != null)
            {
                return handler.Execute(command);
            }
            else
            {
                throw new UnregisteredDomainCommandException( string.Concat( "No command handler registered for \"", command.ToString(), "\""));
            }
        }
    }
}
