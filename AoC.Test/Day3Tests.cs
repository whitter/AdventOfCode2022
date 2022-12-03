using AoC.Day3;
using NUnit.Framework;
using System.Collections.Generic;

namespace AoC.Test
{
    public class Day3Tests
    {
        private string[] _data = null!;

        [OneTimeSetUp]
        public void Setup()
        {
            _data = Program.Parse(@"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw");
        }

        [Test]
        public void Task1_Result()
        {
            var result = Program.Task1(_data);

            Assert.AreEqual(157, result);
        }

        [Test]
        public void Task2_Result()
        {
            var result = Program.Task2(_data);

            Assert.AreEqual(70, result);
        }
    }
}