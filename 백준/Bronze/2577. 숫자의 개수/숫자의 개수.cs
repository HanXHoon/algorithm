namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string totalStr = Enumerable.Range(0, 3)
                                    .Select(_ => Convert.ToInt32(Console.ReadLine()))
                                    .Aggregate((current, next) => current * next)
                                    .ToString();

            int[] result = Enumerable.Range(0, 10)
                                    .Select(s => totalStr.Where(w => w == ('0' + s)).Count())
                                    .ToArray();

            Console.WriteLine(string.Join("\n", result));
        }
    }
}