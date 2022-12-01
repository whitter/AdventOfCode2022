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

        public static IEnumerable<int> Parse(string raw)
        {
            return raw.SplitByBlankLine()
                .Select(x => x.SplitByNewline<int>())
                .Select(x => x.Sum());
        }

        public static int Task1(IEnumerable<int> input)
        {
            return input.Max(x => x);
        }

        public static int Task2(IEnumerable<int> input)
        {
            return input
                .OrderByDescending(x => x)
                .Take(3)
                .Sum();
        }
    }
}