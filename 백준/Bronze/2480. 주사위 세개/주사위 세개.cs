namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dices = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? new string[1], Convert.ToInt32);
            int[] distinctDices = dices.Distinct().ToArray();
            
            if(distinctDices.Length <= 1)            
                Console.WriteLine(10000 + dices[0] * 1000);            
            else if(distinctDices.Length <= 2)
            {
                int duplicateNum = dices.GroupBy(g => g)
                                        .Where(w => w.Count() > 1)
                                        .Select(s => s.Key).First();
                Console.WriteLine(1000 + duplicateNum * 100);
            }
            else            
                Console.WriteLine(dices.Max() * 100);
            
        }
    }
}