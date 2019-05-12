using CAD.VsTemplate2017.Domain.MongoDb1.Commands;
using CommandsAndEvents.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAD.VsTemplate2017.Domain.MongoDb1.CommandHandlers
{
    public class SetValueCommandHandler : CommandHandler<MyAggregateRoot, SetValue>
    {
        protected override void ExecuteCommand(MyAggregateRoot aggregateRoot, SetValue command)
        {
            aggregateRoot.SetValue(command.Value);
        }
    }
}
