using System;

namespace CardGamesEngine.Common.GemProgressReporters
{
    public class ConsoleGameProgressReporter : IGameProgressReporter
    {
        public void Report(object message, bool shouldWaitOnNextStep, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if (shouldWaitOnNextStep)
            {
                Console.ReadLine();
            }
            Console.ResetColor();
        }
    }
}