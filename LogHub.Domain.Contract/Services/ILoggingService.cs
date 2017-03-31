using LogHub.Domain.Contract.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogHub.Domain.Contract.Services
{
    public interface ILoggingService
    {
        /// <summary>
        /// ログを出力を実行します。
        /// </summary>
        /// <param name="payload"></param>
        void Log(SerilogPayload payload);
        void Log(JObject payload);
    }
}
