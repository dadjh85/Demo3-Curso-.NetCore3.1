using Microsoft.Extensions.Logging;
using System.IO;

namespace Demo3.Infrastructure
{
    public static class ILoggerFactoryExtensions
    {
        public static ILoggerFactory UseLogFiles(this ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile($"{Directory.GetCurrentDirectory()}\\Logs\\Logs.txt");
            return loggerFactory;
        }
    }
}
