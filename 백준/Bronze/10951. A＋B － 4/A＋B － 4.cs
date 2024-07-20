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
                string[] str = Console.ReadLine()?.Split(' ') ?? new string[1];

                if (str.Length == 1) break;

                int A = Convert.ToInt32(str[0]);
                int B = Convert.ToInt32(str[1]);

                sb.AppendLine((A + B).ToString());
            }
            Console.WriteLine(string.Join("\n", sb));
        }
    }
}