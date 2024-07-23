namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());

            int result = (X > 0) 
                ? (Y > 0 ? 1 : 4) 
                : (Y > 0 ? 2 : 3);

            Console.WriteLine(result);
        }
    }
}