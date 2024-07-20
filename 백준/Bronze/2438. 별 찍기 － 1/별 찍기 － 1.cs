namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            string [] starArr = Enumerable.Range(1, num).Select(s => string.Concat(Enumerable.Repeat("*", s))).ToArray();

            Console.Write(string.Join("\n", starArr));
        }
    }
}