namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str.Split(' ')[0]);
            int b = Convert.ToInt32(str.Split(' ')[1]);

            Console.WriteLine(a + b);
        }
    }
}