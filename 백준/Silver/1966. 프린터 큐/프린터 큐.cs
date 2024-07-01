using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        struct docInfo
        {
            public int priority;
            public int originIndex;

            public docInfo(int priority, int originIndex)
            {
                this.priority = priority;
                this.originIndex = originIndex;
            }
        }

        static void Main(string[] args)
        {
            string resultStr = "";
            int dataLen = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < dataLen; i++)
            {
                string inputData1 = Console.ReadLine() ?? "";
                string inputData2 = Console.ReadLine() ?? "";

                int documentAmount = Convert.ToInt32(inputData1.Split(' ')[0]);
                int curiousDocIndex = Convert.ToInt32(inputData1.Split(' ')[1]);

                int[] documentArr = inputData2.Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
                int curiousDocPriority = documentArr[curiousDocIndex];

                int outputCnt = 0;

                Queue <docInfo> docInfos = new Queue<docInfo>();
                
                for(int k = 0; k < documentArr.Length; k++)
                {
                    docInfos.Enqueue(new docInfo(documentArr[k], k));
                }

                int maxPriority = docInfos.Max(m => m.priority);

                for(int m = maxPriority; m >= curiousDocPriority; m--)
                {
                    int priorityDocAmount = docInfos.Where(w => w.priority == m).Count();

                    while(priorityDocAmount > 0)
                    {
                        docInfo readQueue = docInfos.Dequeue();

                        if(readQueue.priority == m)
                        {
                            outputCnt++;
                            priorityDocAmount--;
                            if (curiousDocPriority == m && curiousDocIndex == readQueue.originIndex)
                            {
                                resultStr += outputCnt.ToString() + "\n";
                                break;
                            }
                        }
                        else
                        {
                            docInfos.Enqueue(readQueue);
                        }
                    }
                }
            }

            Console.Write(resultStr);
        }
    }
}