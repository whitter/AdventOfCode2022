using AoC.Day6;
using NUnit.Framework;
using System.Collections.Generic;

namespace AoC.Test
{
    public class Day6Tests
    {
        private string _data = "mjqjpqmgbljsphdztnvjfqwrcgsmlb";

        [Test]
        public void Task1_Result()
        {
            var result = Program.Task1(_data);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void Task2_Result()
        {
            var result = Program.Task2(_data);

            Assert.AreEqual(19, result);
        }
    }
}