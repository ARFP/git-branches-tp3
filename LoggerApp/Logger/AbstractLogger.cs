using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp.Logger
{
    public abstract class AbstractLogger
    {
        public const int INFO = 1;
        public const int DEBUG = 2;
        public const int ERROR = 3;

        public abstract void SetNextLogger(AbstractLogger logger);
        public abstract void LogMessage(string message);
        protected abstract void Write(string message);
    }
}
