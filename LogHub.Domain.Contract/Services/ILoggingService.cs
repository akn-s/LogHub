using System;
using System.Collections.Generic;
using System.Text;

namespace LogHub.Domain.Contract.Services
{
    public interface ILoggingService
    {
        /// <summary>
        /// ログを出力します。
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);
    }
}
