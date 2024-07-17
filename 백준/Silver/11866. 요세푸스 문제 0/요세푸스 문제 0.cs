using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine()?.Split(' ') ?? new string[1]; 
            int K = Convert.ToInt32(inputData[0]);
            int N = Convert.ToInt32(inputData[1]);

            int[] numArr = Enumerable.Range(1, K).ToArray();
            int resultCnt = 0;

            string resultStr = "";

            int cnt = 1;
            while(resultCnt < K)
            {
                for (int i = 0; i < numArr.Length; i++)
                {
                    int key = numArr[i];
                    if (key == 0)
                        continue;

                    if (cnt == N)
                    {
                        numArr[i] = 0;
                        resultStr += " " + key.ToString();
                        resultCnt++;
                        cnt = 0;
                    }
                    cnt++;
                }
            }

            Console.WriteLine($"<{string.Join(", ", resultStr.Trim().Split(' '))}>");
        }
    }
}