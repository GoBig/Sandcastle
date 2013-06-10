using System;
using vSol.CQRS.CommandHandlers;
using vSol.CQRS.CommandResults;
using Diary.CQRS.Commands;

namespace Diary.CQRS.CommandHandlers
{
    public class CreateItemCommandHandler : ICommandHandler<CreateItemCommand>
    {
        public CommandResult Execute(CreateItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("CreateItemCommand");
            }
            
            return new CommandResult() { ErrorCode = "0" };
        }
    }
}
