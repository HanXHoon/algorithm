namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numData = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? new string[1], Convert.ToInt32);
            Console.WriteLine((double)numData[0] / numData[1]);
        }
    }
}