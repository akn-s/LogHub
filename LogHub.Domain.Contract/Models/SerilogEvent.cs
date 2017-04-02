using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;
using Newtonsoft.Json;

namespace LogHub.Domain.Contract.Models
{
    [DataContract(Name = "Event")]
    public class SerilogEvent: IModelBase
    {
        public Guid Id { get; set; }
        public string Timestamp { get; set; }
        public string Level { get; set; }
        public string MessageTemplate { get; set; }
        public string Json { get; set; }
    }
}
