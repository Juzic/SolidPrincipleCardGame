using CardGamesEngine.Common.GemProgressReporters;
using CardGamesEngine.Game;

namespace Lecture1
{
    class Program
    {
        static void Main()
        {
            var cardGameRunner = new CardGameRunnerFactory(new ConsoleGameProgressReporter()).Create();
            cardGameRunner.InitGame();
            cardGameRunner.DetermineWinner();
            cardGameRunner.SimulateGame();
			//test
        }
    }
}