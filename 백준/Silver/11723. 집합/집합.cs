
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cmdCnt = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> dict = new Dictionary<int, int>();
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cmdCnt; i++)
            {
                string[] readData = Console.ReadLine()?.Split(' ') ?? new string[0];
                string cmd = readData[0];
                int data = Convert.ToInt32(readData.Length > 1 ? readData[1] : 0);

                switch (cmd)
                {
                    case "add":
                        dict.TryAdd(data, data);
                        break;

                    case "remove":
                        if (dict.ContainsKey(data))
                        {
                            dict.Remove(data);
                        }
                        break;

                    case "check":
                        if (dict.ContainsKey(data))
                        {
                            sb.AppendLine("1");
                        }
                        else
                        {
                            sb.AppendLine("0");
                        }
                        break;

                    case "toggle":
                        if (dict.ContainsKey(data))
                        {
                            dict.Remove(data);
                        }
                        else
                        {
                            dict.TryAdd(data, data);
                        }
                        break;

                    case "all":
                        for(int k = 1 ; k <= 20; k++)
                        {
                            dict.TryAdd(k, k);
                        }
                        break;

                    case "empty":
                        for (int k = 1; k <= 20; k++)
                        {
                            if(dict.ContainsKey(k))
                            {
                                dict.Remove((int)k);
                            }                            
                        }
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}