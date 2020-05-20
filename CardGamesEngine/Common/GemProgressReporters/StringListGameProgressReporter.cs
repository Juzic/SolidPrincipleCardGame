using System;
using System.Collections.Generic;

namespace CardGamesEngine.Common.GemProgressReporters
{
    public class StringListGameProgressReporter : IGameProgressReporter
    {
        public readonly List<string> Messages = new List<string>();
        
        public void Report(object message, bool shouldWaitOnNextStep, ConsoleColor color)
        {
            Messages.Add($"{message}");
        }
    }
}