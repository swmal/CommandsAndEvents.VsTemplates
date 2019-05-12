using CAD.VsTemplate2017.Domain.MongoDb.Commands;
using CommandsAndEvents.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAD.VsTemplate2017.Domain.MongoDb.CommandHandlers
{
    public class SetValueCommandHandler : MongoDbPersistingCommandHandler<MyAggregateRoot, SetValue>
    {
        protected override void ExecuteCommand(MyAggregateRoot aggregateRoot, SetValue command)
        {
            aggregateRoot.SetValue(command.Value);
        }
    }
}
