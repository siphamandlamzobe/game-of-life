using GameOfLife;
using NUnit.Framework;

namespace GameOfLife.Test
{
    public class GameOfLifeTest
    {
        GameOfLife _gameOfLife;

        [SetUp]
        public void SetUp()
        {
            var fileService = new FileService();
            _gameOfLife = new GameOfLife(new GridService(fileService), new NeighboursService(), new GameRulesService());
        }

        [Test]
        public void Given_Generation1_When_FinidngNextGeneration_Should_ReturnNextGeneration()
        {
            var expected = new char[,] {
                { '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '*', '*', '.', '.', '.' },
                { '.', '.', '.', '*', '*', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.' } };
            var actual = _gameOfLife.GetNextGeneration("Generation1TestCase1.txt");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Given_Generation1TestCase2_When_FinidngNextGeneration_Should_ReturnNextGeneration()
        {
            var expected = new char[,] {
                { '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '*', '*', '.', '.', '.' },
                { '.', '.', '.', '*', '*', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.' } };
            var actual = _gameOfLife.GetNextGeneration("Generation1TestCase2.txt");
            Assert.AreEqual(expected, actual);
        }
    }
}