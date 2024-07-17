namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine() ?? "";
            if (str == " ") Console.Write(0);
            else Console.Write(str.Trim().Split(' ').Count());
        }
    }
}