using System;
using vSol.CQRS.Commands;

namespace Diary.CQRS.Commands
{
    public class CreateItemCommand : Command
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ActionOn { get; set; }
        
        public CreateItemCommand(Guid aggregateId,
                                int version,
                                string title,
                                string description, 
                                DateTime actionOn): base(aggregateId, version)
        {
            Title = title;
            Description = description;
            ActionOn = actionOn;
        }
    }
}
