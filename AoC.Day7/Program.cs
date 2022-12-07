using AoC.Common;

namespace AoC.Day7
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

        public static Dictionary<string, int> Parse(string data)
        {
            var commands = data
                .SplitByNewline<string>()
                .Select(x => x.Split(' '))
                .ToArray();

            var result = new Dictionary<string, int>();

            var path = "";

            for (int i = 0; i < commands.Length; i++)
            {
                switch(commands[i][1])
                {
                    case "cd":
                        path = Path.GetFullPath(Path.Combine(path, commands[i][2]));
                        break;
                    case "ls":
                        var files = commands
                            .Skip(i + 1)
                            .TakeWhile(x => x[0] != "$")
                            .Where(x => x[0].All(char.IsAsciiDigit))
                            .Sum(x => int.Parse(x[0]));

                        result.Add(path, files);
                        break;
                }
            }

            foreach (var x in result)
            {
                foreach (var y in result.Where(n => x.Key != n.Key).Where(n => n.Key.StartsWith(x.Key)))
                {
                    result[x.Key] += y.Value;
                }
            }

            return result;
        }

        public static int Task1(Dictionary<string, int> input)
        {
            return input
                .Where(x => x.Value <= 100000)
                .Sum(x => x.Value);
        }

        public static int Task2(Dictionary<string, int> input)
        {
            var space = 30000000 - (70000000 - input.First().Value);

            return input
                .Where(x => x.Value >= space)
                .Min(x => x.Value);
        }
    }
}