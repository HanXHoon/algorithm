namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 400 == 0 ||
              (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}