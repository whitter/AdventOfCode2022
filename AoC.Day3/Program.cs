using AoC.Common;

namespace AoC.Day3
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

        public static string[] Parse(string raw)
        {
            return raw.SplitByNewline<string>();
        }

        public static int Priority(char item) => char.IsLower(item) ? item - 'a' + 1 : item - 'A' + 27;

        public static int Task1(string[] input)
        {
            return input
                .Select(x => x.Chunk(x.Length / 2).ToArray())
                .Select(x => x[0].Intersect(x[1]).Single())
                .Sum(Priority);
        }

        public static int Task2(string[] input)
        {
            return input
                .Chunk(3)
                .Select(x => x[0].Intersect(x[1].Intersect(x[2])).Single())
                .Sum(Priority);
        }
    }
}