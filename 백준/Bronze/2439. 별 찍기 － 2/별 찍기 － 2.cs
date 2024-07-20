using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string result = string.Join("\n", Enumerable.Range(1, num).Select(i => string.Concat(Enumerable.Repeat(" ", num - i))
                                + string.Concat(Enumerable.Repeat("*", i))).ToArray());

            Console.WriteLine(result);
        }
    }
}