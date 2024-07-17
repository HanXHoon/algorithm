namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cmdCnt = Convert.ToInt32(Console.ReadLine());
            string[] chatRecord = Enumerable.Range(0, cmdCnt).Select(_ => Console.ReadLine() ?? "").ToArray();
            string[] splitENTER = string.Join(" ", chatRecord).Split("ENTER");

            int result = splitENTER.Select(s => s.Split(" ").Distinct())
                                .Select(s2 => s2.Where(w => w != "").Count())
                                .Sum();

            Console.WriteLine(result);
        }
    }
}