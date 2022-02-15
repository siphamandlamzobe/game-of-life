using GameOfLife;
using NUnit.Framework;

namespace GameOfLlife.Test
{
    public class GameOfLifeTest
    {
        GameOfLife _gameOfLife;

        [SetUp]
        public void SetUp()
        {
            _gameOfLife = new GameOfLife(new GridService(), new NeighboursService(), new GameRulesService());
        }

        [Test]
        public void Given_Generation1_When_FinidngNextGeneration_Should_ReturnNextGeneration()
        {
            var expected = new char[,] {
                { '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '*', '*', '.', '.', '.' },
                { '.', '.', '.', '*', '*', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.' } };
            var actual = _gameOfLife.GetNextGeneration();
            Assert.AreEqual(expected, actual);
        }
    }
}