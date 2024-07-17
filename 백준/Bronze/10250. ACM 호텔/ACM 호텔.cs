using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCaseNum = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < testCaseNum; i++)
            {
                string[] readData = Console.ReadLine()?.Split(' ') ?? new string[0];
                int H = Convert.ToInt32(readData[0]);
                int W = Convert.ToInt32(readData[1]);
                int N = Convert.ToInt32(readData[2]);

                int floor = N % H;
                if (floor == 0) floor = H;

                int unit = (int)Math.Ceiling((double)N / (double)H) % W;
                if(unit == 0) unit = W;

                int roomNum = floor * 100 + unit;
                sb.AppendLine(roomNum.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}