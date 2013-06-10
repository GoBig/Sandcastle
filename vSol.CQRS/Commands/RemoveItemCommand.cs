using System;
using vSol.CQRS.Commands;

namespace vSol.CQRS.Commands
{
    public class RemoveItemCommand : Command
    {
        public RemoveItemCommand(Guid aggregateId,
                                int version)
            : base(aggregateId, version)
        {
        }
    }
}
