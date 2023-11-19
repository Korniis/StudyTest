using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogService
{
    public class ConsoleLogProvider : ILogProvider
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Error:{msg}");
        }

        public void LogError(string msg)
        {
            Console.WriteLine($":{msg}");
        }

        public void LogInfo(string msg)
        {
            Console.WriteLine($"info:{msg}");
        }
    }
}
