using LogHub.Domain.Contract.Services;
using System;
using System.Collections.Generic;
using System.Text;
using LogHub.Domain.Contract.Models;
using Newtonsoft.Json.Linq;
using System.Linq;
using Newtonsoft.Json;
using LogHub.Infrastructure.Contract.Repositories;

namespace LogHub.Domain.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly ISerilogEventRepository _serilogEventRepository = null; 

        public LoggingService(ISerilogEventRepository serilogEventRepository)
        {
            if (serilogEventRepository == null) throw new ArgumentNullException(nameof(serilogEventRepository));
            _serilogEventRepository = serilogEventRepository;
        }

        public void Log(JObject payload)
        {
            foreach(var event_ in payload["Events"].Children())
            {
                var e = new SerilogEvent() {
                    Id = Guid.NewGuid(),
                    Timestamp = event_["Timestamp"].Value<string>(),
                    Level = event_["Level"].Value<string>(),
                    MessageTemplate = event_["MessageTemplate"].Value<string>(),
                    Json = event_.ToString(),
                };

                _serilogEventRepository.Add(e);
            }
            _serilogEventRepository.Commit();
        }
    }
}
