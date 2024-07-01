using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dataLen = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> workers = new Dictionary<string, string>();

            for (int i = 0; i < dataLen; i++)
            {
                string inputStr = Console.ReadLine();

                string[] inputStrSplit = inputStr.Split(' ');
                string name = inputStrSplit[0];
                string status = inputStrSplit[1];

                if(status == "leave")
                {
                    workers.Remove(name);
                }
                else
                {
                    workers[name] = status;
                }
            }

            var result = workers.OrderByDescending(o => o.Key).Select(s => s.Key).ToList();
            Console.WriteLine(string.Join("\n", result));
        }
    }
}