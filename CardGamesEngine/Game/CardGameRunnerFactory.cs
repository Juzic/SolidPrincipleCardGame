using CardGamesEngine.Common.GemProgressReporters;

namespace CardGamesEngine.Game
{
    public class CardGameRunnerFactory
    {
        public CardGameRunnerFactory(IGameProgressReporter gameProgressReporter)
        {
        }
        
        public ICardGameRunner Create()
        {
            return default; //todo
        }
    }
}