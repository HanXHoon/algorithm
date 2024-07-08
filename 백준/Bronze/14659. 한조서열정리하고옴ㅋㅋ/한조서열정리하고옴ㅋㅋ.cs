namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dataNum = Convert.ToInt32(Console.ReadLine());
            string dataStr = Console.ReadLine() ?? "";
            int[] dataArr = Array.ConvertAll(dataStr.Split(' '), int.Parse);

            int score = 0;
            int maxScore = 0;

            int height = dataArr[0];

            for (int i = 1; i < dataNum; i++)
            {
                if(dataArr[i] > height)
                {
                    height = dataArr[i];
                    score = 0;
                }
                else
                {
                    score++;
                    if(maxScore < score)
                        maxScore = score;
                }
            }

            Console.WriteLine(maxScore.ToString());
        }
    }
}