using AoC.Day7;
using NUnit.Framework;
using System.Collections.Generic;

namespace AoC.Test
{
    public class Day7Tests
    {
        private Dictionary<string, int> _data = null!;

        [OneTimeSetUp]
        public void Setup()
        {
            _data = Program.Parse(@"$ cd /
$ ls
dir a
14848514 b.txt
8504156 c.dat
dir d
$ cd a
$ ls
dir e
29116 f
2557 g
62596 h.lst
$ cd e
$ ls
584 i
$ cd ..
$ cd ..
$ cd d
$ ls
4060174 j
8033020 d.log
5626152 d.ext
7214296 k");
        }

        [Test]
        public void Task1_Result()
        {
            var result = Program.Task1(_data);

            Assert.AreEqual(95437, result);
        }

        [Test]
        public void Task2_Result()
        {
            var result = Program.Task2(_data);

            Assert.AreEqual(24933642, result);
        }
    }
}