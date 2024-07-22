namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine()?.Split(' ')[1]);
            int[] num = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? new string[1], Convert.ToInt32);

            Console.WriteLine(string.Join(' ', num.Where(w => w < X).ToArray()));
        }
    }
}