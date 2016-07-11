using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace MoneyManager.Shared.Logger
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger<T>()
        {
            return new Logger(LogManager.GetLogger(typeof(T).FullName));
        }

        public ILogger CreateLogger(Type type)
        {
            return new Logger(LogManager.GetLogger(type.FullName));
        }
    }

    public interface ILoggerFactory
    {
        ILogger CreateLogger<T>();
        ILogger CreateLogger(Type type);
    }
}
