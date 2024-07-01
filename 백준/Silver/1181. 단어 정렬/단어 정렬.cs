namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dataLen = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[dataLen];

            for(int i = 0; i < dataLen; i++)
            {
                words[i] = (Console.ReadLine() ?? "");
            }

            var result = words.GroupBy(g => g.Length)
                            .OrderBy(o => o.Key)
                            .Select(s => string.Join("\n", s.Distinct().OrderBy(w => w)));

            Console.WriteLine(string.Join("\n", result));
        }
    }
}