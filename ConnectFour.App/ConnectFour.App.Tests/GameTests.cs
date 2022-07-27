using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.App.Tests
{
    [TestFixture]
    internal class GameTests
    {

        [Test]
        public void IsGameEnded_WholeRowIsEmpty_False()
        {
            var game = new Game();

            var isGameEndedResult = game.IsGameEnded();
            
            Assert.IsFalse(isGameEndedResult);
        }

        [Test]
        public void IsGameEnded_WholeRowIsFullOfPlayerGValues_True()
        {
            var game = new Game();

            game.MakeMove(new Coordinate(3,0), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3,1), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3,2), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3,3), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3,4), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3,5), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3,6), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3,7), PlayerMarkerEnum.PlayerG);

            var isGameEndedResult = game.IsGameEnded();

            Assert.IsTrue(isGameEndedResult);
        }

        [Test]
        public void IsGameEnded_RowFirstFivePopulatedWithPlayerGExceptThirdOneEmpty_False()
        {
            var game = new Game();

            game.MakeMove(new Coordinate(3, 0), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3, 1), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3, 3), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3, 4), PlayerMarkerEnum.PlayerG);

            var isGameEndedResult = game.IsGameEnded();

            Assert.IsFalse(isGameEndedResult);
        }

        [Test]
        public void IsGameEnded_RowFirstTwoPlayerGLastTwoPlayerG_False()
        {
            var game = new Game();

            game.MakeMove(new Coordinate(3, 0), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3, 1), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3, 6), PlayerMarkerEnum.PlayerG);
            game.MakeMove(new Coordinate(3, 7), PlayerMarkerEnum.PlayerG);

            var isGameEndedResult = game.IsGameEnded();

            Assert.IsFalse(isGameEndedResult);
        }
    }
}



