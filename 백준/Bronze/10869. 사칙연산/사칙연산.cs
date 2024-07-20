using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine()?.Split(' ') ?? new string[1];
            int A = Convert.ToInt32(str[0]);
            int B = Convert.ToInt32(str[1]);

            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);
        }
    }
}