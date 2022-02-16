using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Test
{
    public class BooleanArrayServiceTest
    {
        BooleanArrayService _booleanArrayService;

        [SetUp]
        public void SetUp()
        {
            _booleanArrayService = new BooleanArrayService();
        }

        [Test]
        public void Given_StringArray_When_ConvertingToBooleanArray_Should_ReturnBooleanArray()
        {
            var stringArray = new string[]{ "........", "....*...", "...**...", "........" };

            var rowLength = 8;

            var rowCount = 4;

            var actual = _booleanArrayService.ConvertToBooleanArray(stringArray, rowLength, rowCount);

            var expected = new bool[,] {
                { false, false, false, false, false, false, false, false },
                { false, false, false, false, true, false, false, false },
                { false, false, false, true, true, false, false, false },
                { false, false, false, false, false, false, false, false } };


            Assert.AreEqual(expected, actual);
        }
    }
}
