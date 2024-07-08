using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            int testCaseNum = Convert.ToInt32(Console.ReadLine());

            StringBuilder resultSB = new StringBuilder();

            for (int i = 0; i < testCaseNum; i++)
            {
                int readData = Convert.ToInt32(Console.ReadLine());
                if(readData == 0)
                {
                    int dequeueData = 0, dequeuePriority = 0;
                    bool dequeueResult = false;

                    dequeueResult = pq.TryDequeue(out dequeueData, out dequeuePriority);
                    if (!dequeueResult)                    
                        resultSB.AppendLine("0");
                    else                    
                        resultSB.AppendLine(dequeueData.ToString());
                }
                else
                {
                    pq.Enqueue(readData, readData);
                }
            }

            Console.WriteLine(resultSB.ToString().Trim());
        }
    }
}