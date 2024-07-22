namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numArr = Enumerable.Range(1, num).ToArray();
            
            Console.WriteLine(string.Join("\n", numArr));
        }
    }
}