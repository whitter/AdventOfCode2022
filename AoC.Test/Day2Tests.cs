using AoC.Day2;
using NUnit.Framework;
using System.Collections.Generic;

namespace AoC.Test
{
    public class Day2Tests
    {
        private (int, int)[] _data = null!;

        [OneTimeSetUp]
        public void Setup()
        {
            _data = Program.Parse(@"A Y
B X
C Z");
        }

        [Test]
        public void Task1_Result()
        {
            var result = Program.Task1(_data);

            Assert.AreEqual(15, result);
        }

        [Test]
        public void Task2_Result()
        {
            var result = Program.Task2(_data);

            Assert.AreEqual(12, result);
        }
    }
}