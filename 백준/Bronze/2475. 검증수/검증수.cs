namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? new string[1], Convert.ToInt32);
            
            int sum = (int)Enumerable.Range(0, 5).Select(s => Math.Pow(num[s], 2)).Sum();
            Console.WriteLine(sum % 10);
        }
    }
}