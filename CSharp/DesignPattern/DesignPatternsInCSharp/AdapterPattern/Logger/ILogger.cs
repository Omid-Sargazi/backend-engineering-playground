using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AdapterPattern.Logger
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class LegacyLogger
    {
        public void WriteLogToFile(string msg)
        {
            Console.WriteLine($"Legacy Log: {msg}");
        }
    }

    public class LoggerAdapter : ILogger
    {
        private readonly LegacyLogger logger;
        public LoggerAdapter(LegacyLogger legacyLogger)
        {
            logger = legacyLogger;
        }
        public void Log(string message)
        {
            logger.WriteLogToFile(message);
        }
    }
}
