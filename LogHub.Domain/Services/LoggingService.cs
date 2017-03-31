using LogHub.Domain.Contract.Services;
using System;
using System.Collections.Generic;
using System.Text;
using LogHub.Domain.Contract.Models;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace LogHub.Domain.Services
{
    public class LoggingService : ILoggingService
    {
        public void Log(SerilogPayload payload)
        {
            throw new NotImplementedException();
        }

        public void Log(JObject payload)
        {
            foreach(var event_ in payload["Events"].Children())
            {
                var timeStamp = event_["Timestamp"].Value<string>();
            }

            throw new NotImplementedException();
        }
    }
}
