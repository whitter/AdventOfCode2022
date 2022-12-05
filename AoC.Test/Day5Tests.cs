using AoC.Day5;
using NUnit.Framework;
using System.Collections.Generic;

namespace AoC.Test
{
    public class Day5Tests
    {
        private (char[][], (int, int, int)[]) _data;

        [OneTimeSetUp]
        public void Setup()
        {
            _data = Program.Parse(@"    [D]    
[N] [C]    
[Z] [M] [P]
 1   2   3 

move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2");
        }

        [Test]
        public void Task1_Result()
        {
            var result = Program.Task1(_data);

            Assert.AreEqual("CMZ", result);
        }

        [Test]
        public void Task2_Result()
        {
            var result = Program.Task2(_data);

            Assert.AreEqual("MCD", result);
        }
    }
}