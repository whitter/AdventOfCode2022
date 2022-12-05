using AoC.Common;
using MoreLinq;
using System.Text.RegularExpressions;

namespace AoC.Day5
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

        public static (char[][], (int, int, int)[]) Parse(string raw)
        {
            var sections = raw.SplitByBlankLine();

            var stacks = sections[0]
                .SplitByNewline<string>()
                .Transpose()
                .Select(x => x.Where(char.IsAsciiLetter).Reverse().ToArray())
                .Where(x => x.Any())
                .ToArray();

            var regex = new Regex(@"(\d+)");

            var instructions = sections[1]
                .SplitByNewline<string>()
                .Select(x => regex.Matches(x).Select(x => int.Parse(x.Value)).ToArray())
                .Select(x => (x[0], x[1], x[2]))
                .ToArray();

            return (stacks, instructions);
        }

        private static Stack<char>[] BuildStacks(char[][] stacks)
        {
            return stacks
                .Select(x => new Stack<char>(x))
                .ToArray();
        }

        private static string Process((int, int, int)[] instructions, Stack<char>[] stacks, bool multiple = false)
        {
            var crane = new Stack<char>();

            foreach((int qty, int from, int to) in instructions)
            {
                for(int i = 0; i < qty; i++)
                {
                    if (stacks[from - 1].TryPop(out char value))
                    {
                        if (multiple)
                        {
                            crane.Push(value);

                            continue;
                        }

                        stacks[to - 1].Push(value);
                    }
                }

                if(multiple)
                {
                    while(crane.TryPop(out char value))
                    {
                        stacks[to - 1].Push(value);
                    }
                }
            }

            var result = "";

            foreach (var stack in stacks)
            {
                if (stack.TryPop(out char value))
                {
                    result += value;
                }
            }

            return result;
        }

        public static string Task1((char[][] stacks, (int, int, int)[] instructions) input)
        {
            var stacks = BuildStacks(input.stacks);

            var result = Process(input.instructions, stacks);

            return result;
        }

        public static string Task2((char[][] stacks, (int, int, int)[] instructions) input)
        {
            var stacks = BuildStacks(input.stacks);

            var result = Process(input.instructions, stacks, true);

            return result;
        }
    }
}