using CAD.VsTemplate2017.Domain.MongoDb1.Events;
using CommandsAndEvents;
using System;

namespace CAD.VsTemplate2017.Domain.MongoDb1
{
    /// <summary>
    /// A sample aggregate root
    /// </summary>
    public class MyAggregateRoot : AggregateRoot
    {
        public string Value { get; set; }

        public void SetValue(string value)
        {
            Value = value;
            EmitEvent(new ValueSet { Value = value });
        }
    }
}
