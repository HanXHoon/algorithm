
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            char[] charArr = str.ToCharArray();
            char[] sortArr = charArr.OrderByDescending(x => x).ToArray();

            string resultStr = new string(sortArr);
            Console.WriteLine(resultStr);
        }
    }
}