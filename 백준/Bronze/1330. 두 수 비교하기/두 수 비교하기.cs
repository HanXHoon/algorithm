namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numData = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? new string[1], Convert.ToInt32);
            string resultStr = "<=>".Substring(1 + numData[0].CompareTo(numData[1]), 1);
            resultStr = resultStr == "=" ? "==" : resultStr;
            Console.Write(resultStr);
        }
    }
}