using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine() ?? "";
            StringBuilder resultSB = new StringBuilder();

            int alphabet = 'a';
            int alphabetEnd = 'z' - 'a';
            for(int i = 0; i <= alphabetEnd; i++)
            {
                resultSB.Append(inputStr.IndexOf((char)(alphabet + i)).ToString() + " ");
            }

            Console.WriteLine(resultSB.ToString().Trim());
        }
    }
}