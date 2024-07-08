using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCaseNum = Convert.ToInt32(Console.ReadLine());
            StringBuilder resultSB = new StringBuilder();

            for(int i = 0; i < testCaseNum; i++)
            {
                string[] testCase = Console.ReadLine()?.Split(' ') ?? new string[0];

                int repeatNum = Convert.ToInt32(testCase[0]);
                string word = testCase[1];

                resultSB.AppendLine(string.Concat(word.Select(s => new string(s, repeatNum))));
            }

            Console.WriteLine(resultSB.ToString());
        }
    }
}