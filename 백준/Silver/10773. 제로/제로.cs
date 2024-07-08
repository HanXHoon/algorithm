namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            int[] dataArr = Enumerable.Range(0, num)
                                        .Select(_ => Convert.ToInt32(Console.ReadLine())).ToArray();

            foreach(int data in dataArr)
            {
                int temp = 0;
                if (data == 0)
                    stack.TryPop(out temp);
                else
                    stack.Push(data);
            }

            Console.WriteLine(stack.Sum(s => s).ToString());
        }
    }
}