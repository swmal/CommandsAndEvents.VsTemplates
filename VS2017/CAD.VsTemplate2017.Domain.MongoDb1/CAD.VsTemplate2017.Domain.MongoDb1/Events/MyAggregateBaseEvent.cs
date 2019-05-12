using CommandsAndEvents.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAD.VsTemplate2017.Domain.MongoDb1.Events
{
    public abstract class MyAggregateBaseEvent : Event
    {
        public override sealed string Stream => "MyAggregateRoot";
    }
}
