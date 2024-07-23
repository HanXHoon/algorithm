namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? new string[1], Convert.ToInt64).Sum();
            Console.WriteLine(result);
        }
    }
}