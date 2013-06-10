using System;
using System.Diagnostics;
using vSol.CQRS.CommandResults;
using vSol.CQRS.Commands;

namespace vSol.CQRS.CommandHandlers
{
    public class RemoveItemCommandHandler : ICommandHandler<RemoveItemCommand>
    {
        public CommandResult Execute(RemoveItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("RemoveItemCommand");
            }

            return new CommandResult() { ErrorCode = "0" };
        }
    }
}
