﻿using CommandsAndEvents.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAD.VsTemplate2017.Domain.Events
{
    public class ValueSet : MyAggregateBaseEvent
    {
        public string Value { get; set; }
    }
}
