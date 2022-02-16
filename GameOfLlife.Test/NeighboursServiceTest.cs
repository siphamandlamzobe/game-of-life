using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Test
{
    public class NeighboursServiceTest
    {
        NeighboursService _neighboursService;

        [SetUp]
        public void SetUp()
        {
            _neighboursService = new NeighboursService();
        }

        [TestCase(new bool[] { false, true, false, false, false }, 1)]
        [TestCase(new bool[] { false, true, false, true, false }, 2)]
        [TestCase(new bool[] { false, true, false, true, true }, 3)]
        [TestCase(new bool[] { true, true, true, true, true }, 5)]
        public void Given_BooleanArray_WhenFindingNumberOfLiveNeighbours_Should_Return_NumberOfLiveCells(bool[] neighbors, int expected)
        {
            Assert.AreEqual(expected, _neighboursService.FindNumberOfLiveNeighbours(neighbors));
        }

        [Test]
        public void Given_FirstGenerationGridForElement00_When_FindingNeighbours_Should_ReturnBooleanArrayWithNeigbhours()
        {
            var firstGeneration = new bool[,] {
                { false, false, false, false, false, false, false, false },
                { false, false, false, false, true, false, false, false },
                { false, false, false, true, true, false, false, false },
                { false, false, false, false, false, false, false, false } };

            var expected = new bool[] {false, false, false, false, false, false, false, false };
            var row = 0;
            var col = 0;
            var actual = _neighboursService.FindNeighbours(firstGeneration, row, col);
            Assert.AreEqual(expected, actual);
        }
    }
}
