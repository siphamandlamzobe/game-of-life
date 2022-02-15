using NUnit.Framework;

namespace GameOfLlife.Test
{
    public class GameOfLifeTest
    {
        private readonly IGameOfLife _gameOfLife;

        public GameOfLifeTest(IGameOfLife gameOfLife)
        {
            _gameOfLife = gameOfLife;
        }

        public GameOfLifeTest() : this(new GameOfLife())
        {

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