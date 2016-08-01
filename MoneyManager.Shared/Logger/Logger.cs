using System;
using log4net;

namespace MoneyManager.Shared.Logger
{
    public class Logger : ILogger
    {
        private readonly ILog _log;

        public Logger(ILog log)
        {
            _log = log;
        }

        public void Debug(string message)
        {
            if (_log.IsDebugEnabled)
                _log.Debug(message);
        }

        public void Debug(Exception ex)
        {
            if (_log.IsDebugEnabled)
                _log.Debug(ex);
        }
    }

    public interface ILogger
    {
        void Debug(string message);

        void Debug(Exception ex);

        //void Debug(CallerInfo info, string message, params object[] args);


        //void Info(string message, params object[] args);

        //void Info(CallerInfo info, string message, params object[] args);


        //void Warn(string message, params object[] args);

        //void Warn(CallerInfo info, string message, params object[] args);


        //void Error(Exception ex, string message, params object[] args);


        //void Error(string message, params object[] args);

        //void Error(CallerInfo info, string message, params object[] args);


        //void Fatal(string message, params object[] args);

        //void Fatal(CallerInfo info, string message, params object[] args);
    }
}
