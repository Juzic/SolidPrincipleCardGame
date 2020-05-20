using System;

namespace CardGamesEngine.Common.GemProgressReporters
{
    public interface IGameProgressReporter
    {
        void Report(object message, bool shouldWaitOnNextStep, ConsoleColor color);
    }
}