using System.Linq;
using CardGamesEngine.Common.GemProgressReporters;
using CardGamesEngine.Game;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Lecture1
{
    /// <summary>
    /// Design and develop simple card game for fraudulent House
    /// 
    /// - Use strictly S O L I D design principles
    /// - Each team has 100 points at the beginning
    /// - Each team will lose one point each time it violates S O L I D design principles on each class or method
    /// - If team gets totally lost, he can ask for help, it will cost 10 points
    /// - Team with zero points lose and game is over
    /// - At the end, 3 teams with highest number of points gets rewarded
    /// 
    /// Description of game:
    /// - The game consists of:
    /// -- Deck: stack of cards, where player can get cards
    /// -- Heap: stack of cards, where player put away cards
    /// -- Players: group of players
    /// - Rules of the game:
    /// -- Init phase:
    /// --- in the Deck there are 21 shuffled cards
    /// --- first card on top will be moved to the Heap
    /// --- each player one by one will take one card from the Deck until the Cards will run out from the Deck
    /// -- Play phase:
    /// --- there are game rounds
    /// --- each round each player, starting from first player, will try to put away one card to Heap
    /// --- each player will look at the Heap, and if he has card with value +1, he will put it on the Heap
    /// --- winner is player with zero cards in hand
    /// -- Application must provide mechanism to watch the game (already implemented)
    /// -- For House, it is important to determine winner of the Game during the Game
    /// </summary>
    public class CardGame1Test
    {
        [Test]
        [Repeat(10)]
        public void Test()
        {
            //preparation
            var progressReporter = new StringListGameProgressReporter();
            var cardGameRunner = new CardGameRunnerFactory(progressReporter).Create();

            cardGameRunner.InitGame();
            
            //run
            var determinedWinner = cardGameRunner.DetermineWinner();

            var winner = cardGameRunner.SimulateGame();

            //test
            determinedWinner.Should().NotBeEmpty();
            winner.Should().NotBeEmpty();

            winner.Should().Be(determinedWinner);
            
            var lastMessage = progressReporter.Messages.Last();
            lastMessage.Should().Contain("Game finished, winner is");
            lastMessage.Should().Contain(determinedWinner);
        }
    }
}