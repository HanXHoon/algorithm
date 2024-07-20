namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}