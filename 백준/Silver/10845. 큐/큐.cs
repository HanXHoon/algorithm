namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCounts = Convert.ToInt32(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            string resultStr = "";

            for(int i = 0; i < commandCounts; i++)
            {
                string command = Console.ReadLine() ?? "";
                bool isSuccess = false;
                int result = 0;
                switch (command)
                {
                    case "pop":
                        isSuccess = queue.TryDequeue(out result);
                        result = isSuccess ? result : -1;
                        break;

                    case "size":
                        result = queue.Count;
                        break;

                    case "empty":
                        result = queue.Count <= 0 ? 1 : 0;
                        break;

                    case "front":
                        isSuccess = queue.TryPeek(out result);
                        result = isSuccess ? result : -1;
                        break;

                    case "back":
                        if(queue.Count != 0)
                            result = queue.Last();
                        else
                            result = -1;
                        break;

                    //push
                    default:
                        int x = Convert.ToInt32(command.Split(' ')[1]);
                        queue.Enqueue(x);
                        break;
                }

                if (!command.Contains("push"))
                {
                    resultStr += result.ToString() + "\n";
                }
            }
            Console.Write(resultStr);
        }
    }
}