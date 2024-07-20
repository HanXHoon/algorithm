using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int testCaseNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCaseNum; i++)
            {
                string[] str = Console.ReadLine()?.Split(' ') ?? new string[2];

                int A = Convert.ToInt32(str[0]);
                int B = Convert.ToInt32(str[1]);

                sb.AppendLine((A + B).ToString());
            }

            Console.Write(sb);
        }
    }
}