using AoC.Day4;
using NUnit.Framework;
using System.Collections.Generic;

namespace AoC.Test
{
    public class Day4Tests
    {
        private int[][][] _data = null!;

        [OneTimeSetUp]
        public void Setup()
        {
            _data = Program.Parse(@"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8");
        }

        [Test]
        public void Task1_Result()
        {
            var result = Program.Task1(_data);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Task2_Result()
        {
            var result = Program.Task2(_data);

            Assert.AreEqual(4, result);
        }
    }
}