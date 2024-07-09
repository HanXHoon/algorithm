using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = Console.ReadLine()?.Split(' ') ?? new string[0];

            int stuffCount = Convert.ToInt32(inputStr[0]);
            int maxWeight = Convert.ToInt32(inputStr[1]);

            int[] stuffWeights = new int[stuffCount];
            int[] stuffValues = new int[stuffCount];

            for (int i = 0; i < stuffCount; i++)
            {
                string[] stuffData = Console.ReadLine()?.Split(' ') ?? new string[0];
                stuffWeights[i] = Convert.ToInt32(stuffData[0]);
                stuffValues[i] = Convert.ToInt32(stuffData[1]);
            }

            int[,] dp = new int[stuffCount + 1, maxWeight + 1];

            for (int i = 0; i < stuffCount; i++)
            {
                for (int w = 0; w <= maxWeight; w++)
                {
                    if (stuffWeights[i] <= w)
                    {
                        dp[i + 1, w] = Math.Max(dp[i, w], 
                                            dp[i, w - stuffWeights[i]] + stuffValues[i]);
                    }
                    else
                    {
                        dp[i + 1, w] = dp[i, w];
                    }
                }
            }

            Console.WriteLine(dp[stuffCount, maxWeight].ToString());
        }
    }
}