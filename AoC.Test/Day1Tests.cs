using AoC.Day1;
using NUnit.Framework;
using System.Collections.Generic;

namespace AoC.Test
{
    public class Day1Tests
    {
        private IEnumerable<int> _data = null!;

        [OneTimeSetUp]
        public void Setup()
        {
            _data = Program.Parse(@"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000");
        }

        [Test]
        public void Task1_Result()
        {
            var result = Program.Task1(_data);

            Assert.AreEqual(24000, result);
        }

        [Test]
        public void Task2_Result()
        {
            var result = Program.Task2(_data);

            Assert.AreEqual(45000, result);
        }
    }
}