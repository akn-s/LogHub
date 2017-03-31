using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogHub.Domain.Contract.Services;
using LogHub.Domain.Contract.Models;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogHub.Web.Controllers.API
{
    [Route("api/events/raw")]
    public class LogsController : Controller
    {
        private readonly ILoggingService _loggingService = null;

        public LogsController(ILoggingService loggingService)
        {
            if (loggingService == null) throw new ArgumentNullException(nameof(loggingService));
            _loggingService = loggingService;
        }

        [HttpPost]
        public void Post([FromBody]JObject payload)
        {
            _loggingService.Log(payload);
        }
    }
}
