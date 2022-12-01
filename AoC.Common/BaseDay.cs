namespace AoC.Common
{
    public abstract class BaseDay
    {
        protected static string Load() => File.ReadAllText("input.txt");
    }
}