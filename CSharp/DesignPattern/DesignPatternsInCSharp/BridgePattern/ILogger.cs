using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern
{
    public interface ILogger
    {
        void Log(string message);
    }


    public class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine($"Console Log: {message}");
    }

    public class FileLogger : ILogger
    {
        public FileLogger()
        {
        }

        public void Log(string message) => File.AppendAllText("log.txt", $"File Log: {message}\n");
    }
}
