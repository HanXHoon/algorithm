namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] data = Console.ReadLine()?.Split(' ') ?? new string[0];

            int[] numData = Array.ConvertAll(data, int.Parse);

            Console.WriteLine($"{numData.Min()} {numData.Max()}");
        }
    }
}