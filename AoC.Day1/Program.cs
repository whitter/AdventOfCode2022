using AoC.Common;

namespace AoC.Day1
{
    public class Program : BaseDay
    {
        static void Main(string[] args)
        {
            var raw = Load();

            var data = Parse(raw);

            Console.WriteLine($"Task 1: {Task1(data)}");
            Console.WriteLine($"Task 2: {Task2(data)}");
        }

        public static int[] Parse(string raw)
        {
            return raw.SplitByBlankLine()
                .Select(x => x.SplitByNewline<int>())
                .Select(x => x.Sum())
                .OrderByDescending(x => x)
                .ToArray();
        }

        public static int Task1(int[] input)
        {
            return input.First();
        }

        public static int Task2(int[] input)
        {
            return input
                .Take(3)
                .Sum();
        }
    }
}