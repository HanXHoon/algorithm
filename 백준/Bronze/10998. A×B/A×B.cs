namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? new string[1], Convert.ToInt32);
            Console.WriteLine(num[0] * num[1]);
        }
    }
}