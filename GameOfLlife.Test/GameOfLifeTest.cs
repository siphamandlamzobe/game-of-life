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
        public void Test1()
        {
            Assert.AreEqual("", _gameOfLife.GetNextGeneration());
        }
    }
}