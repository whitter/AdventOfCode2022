using AoC.Common;
using MoreLinq;

namespace AoC.Day6
{
    public class Program : BaseDay
    {
        static void Main(string[] args)
        {
            var raw = Load();

            Console.WriteLine($"Task 1: {Task1(raw)}");
            Console.WriteLine($"Task 2: {Task2(raw)}");
        }

        private static int Process(string input, int size = 4)
        {
            var distinct = input
                .Window(size)
                .Index()
                .First(x => x.Value.Distinct().Count() == size);

            return distinct.Key + size;
        }

        public static int Task1(string input) => Process(input);

        public static int Task2(string input) => Process(input, 14);
    }
}