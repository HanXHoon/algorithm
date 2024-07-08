using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCaseNum = Convert.ToInt32(Console.ReadLine());
            StringBuilder resultSB = new StringBuilder();

            for (int i = 0; i < testCaseNum; i++)
            {
                string inputStr = Console.ReadLine() ?? "";
                string[] testCase = Regex.Replace(inputStr, "X+", "X").Split('X');

                int totalSum = testCase.Sum(s => s.Length * (s.Length + 1) / 2);

                resultSB.AppendLine(totalSum.ToString());
            }

            Console.WriteLine(resultSB.ToString().Trim());
        }
    }
}