using System;
using System.Collections.Generic;
using System.Text;
using CommandsAndEvents;
using CommandsAndEvents.Commands;
using CommandsAndEvents.MongoDb;

namespace CAD.VsTemplate2017.Domain.MongoDb.CommandHandlers
{
    public abstract class MongoDbPersistingCommandHandler<T, T1> : CommandHandler<T, T1>
        where T : AggregateRoot, new()
        where T1 : Command<T>
    {
        protected override void OnCommandExecuted(T aggregateRoot)
        {
            var repository = new MongoDbRepository<T>("mongodb://127.0.0.1:27018", "MyBoundedContext");
            repository.Save(aggregateRoot);
        }
    }
}
