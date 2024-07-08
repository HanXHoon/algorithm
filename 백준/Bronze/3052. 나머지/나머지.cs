namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = Enumerable.Range(0, 10)
                                        .Select(_ => Convert.ToInt32(Console.ReadLine()) % 42)
                                        .GroupBy(g => g)
                                        .Count()
                                        .ToString();

            Console.WriteLine(result);
        }
    }
}