using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string[] str = Console.ReadLine()?.Split(' ') ?? new string[2];

                int A = Convert.ToInt32(str[0]);
                int B = Convert.ToInt32(str[1]);

                if (A == 0 && B == 0) break;

                sb.AppendLine((A + B).ToString());
            }
            Console.Write(sb);
        }
    }
}