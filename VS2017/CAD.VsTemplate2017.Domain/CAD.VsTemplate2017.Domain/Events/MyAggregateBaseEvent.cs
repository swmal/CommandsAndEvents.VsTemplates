using CommandsAndEvents.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAD.VsTemplate2017.Domain.Events
{
    public abstract class MyAggregateBaseEvent : Event
    {
        public override sealed string Stream => "MyAggregateRoot";
    }
}
