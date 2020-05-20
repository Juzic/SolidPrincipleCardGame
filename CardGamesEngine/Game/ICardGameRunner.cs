namespace CardGamesEngine.Game
{
    public interface ICardGameRunner
    {
        void InitGame();
        string DetermineWinner();
        string SimulateGame();
    }
}