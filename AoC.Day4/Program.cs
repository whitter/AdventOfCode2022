using AoC.Common;

namespace AoC.Day4
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

        public static int[][][] Parse(string raw)
        {
            return raw.SplitByNewline<string>()
                .Select(x => x.SplitBy<string>(",").Select(y => y.SplitBy<int>("-")).ToArray())
                .ToArray();
        }

        public static int Task1(int[][][] input)
        {
            return input
                .Where(x => (x[0][0] >= x[1][0] && x[0][1] <= x[1][1]) || (x[0][0] <= x[1][0] && x[0][1] >= x[1][1]))
                .Count();
        }

        public static int Task2(int[][][] input)
        {
            return input
                .Where(x => x[0][0] <= x[1][1] && x[1][0] <= x[0][1])
                .Count();
        }
    }
}