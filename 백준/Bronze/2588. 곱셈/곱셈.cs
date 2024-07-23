namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = Convert.ToInt32(Console.ReadLine());
            int[] numB = Array.ConvertAll(Console.ReadLine()?.Select(s => s.ToString()).ToArray() ?? new string[1], Convert.ToInt32);
            
            int calcA = numA * numB[2];
            int calcB = numA * numB[1];
            int calcC = numA * numB[0];

            int result = calcC * 100 + calcB * 10 + calcA;

            Console.WriteLine($"{calcA}\n{calcB}\n{calcC}\n{result}");
        }
    }
}