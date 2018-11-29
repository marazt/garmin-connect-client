using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics.CodeAnalysis;

namespace GarminConnectClient.Console
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            System.Console.WriteLine($"Error: {message}");
        }

        public void Information(string message)
        {
            System.Console.WriteLine($"Information: {message}");
        }

        public void Warning(string message)
        {
            System.Console.WriteLine($"warning: {message}");
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            System.Console.WriteLine(state.ToString());
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }
    }

    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class ConsoleLogger<T> : ILogger<T>
    {
        public void Error(string message)
        {
            System.Console.WriteLine($"Error: {message}");
        }

        public void Information(string message)
        {
            System.Console.WriteLine($"Information: {message}");
        }

        public void Warning(string message)
        {
            System.Console.WriteLine($"warning: {message}");
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            System.Console.WriteLine(state.ToString());
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }
    }
}