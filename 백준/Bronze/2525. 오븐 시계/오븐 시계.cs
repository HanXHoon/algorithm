namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = Array.ConvertAll(Console.ReadLine()?.Split(' ') ?? new string[1], Convert.ToInt32);
            int requiredTime = Convert.ToInt32(Console.ReadLine());
            
            TimeOnly to = new(time[0], time[1]);
            to = to.AddMinutes(requiredTime);

            Console.WriteLine(to.ToString("H m"));
        }
    }
}