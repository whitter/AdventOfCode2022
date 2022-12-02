using AoC.Common;

namespace AoC.Day2
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

        public static (int,int)[] Parse(string raw)
        {
            return raw.SplitByNewline<string>()
                .Select(x => x.SplitBy<char>(" "))
                .Select(x => (x[0] - 'A', x[1] - 'X'))
                .ToArray();
        }

        public static int Score(int op, int me)
        {
            int score = me + 1;

            if (op == me)
            {
                score += 3;
            }
            else if (me == (op + 1) % 3)
            {
                score += 6;
            }

            return score;
        }

        public static int Task1((int, int)[] input)
        {
            int score = 0;

            foreach((int op, int me) round in input)
            {
                score += Score(round.op, round.me);
            }

            return score;
        }

        public static int Task2((int, int)[] input)
        {
            int score = 0;
            
            foreach ((int op, int me) round in input)
            {
                var mod = (round.op + round.me - 1) % 3;
                score += Score(round.op, mod < 0 ? mod + 3 : mod);
            }            

            return score;
        }
    }
}