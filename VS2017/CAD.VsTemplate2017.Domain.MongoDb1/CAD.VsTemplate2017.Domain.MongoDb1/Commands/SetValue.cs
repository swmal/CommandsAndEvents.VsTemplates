using CommandsAndEvents.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CAD.VsTemplate2017.Domain.MongoDb1.Commands
{
    public class SetValue : Command<MyAggregateRoot>
    {
        [Required]
        public string Value { get; set; }
    }
}
