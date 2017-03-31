using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;
using Newtonsoft.Json;

namespace LogHub.Domain.Contract.Models
{
    [DataContract(Name = "EventId")]
    public class SerilogEventId
    {
        public int Id { get; set; }
    }

    [DataContract(Name = "Properties")]
    public class SerilogProperties
    {
     //   List<KeyValuePair<string, string>> 
    }

    [DataContract(Name = "HostingRequestStarting")]
    public class SerilogHostingRequestStarting
    {
        public string Format { get; set; }
        public string Rendering { get; set; }
    }

    [DataContract(Name = "HostingRequestFinished")]
    public class SerilogHostingRequestFinished
    {
        public string Format { get; set; }
        public string Rendering { get; set; }
    }

    [DataContract(Name = "Renderings")]
    public class SerilogRenderings
    {
        public List<SerilogHostingRequestStarting> HostingRequestStarting { get; set; }
        public List<SerilogHostingRequestFinished> HostingRequestFinished { get; set; }
    }

    [DataContract(Name = "Event")]
    public class SerilogEvent
    {
        public string Timestamp { get; set; }
        public string Level { get; set; }
        public string MessageTemplate { get; set; }
        public List<KeyValuePair<string, object>> Properties { get; set; }
        public SerilogRenderings Renderings { get; set; }
    }

    public class SerilogPayload
    {
        public List<SerilogEvent> Events { get; set; }
    }
}
