namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = Convert.ToInt32(Console.ReadLine());

                for(int i = 0 ; i < 4 ; i++){
                    int threshold = 90 - 10 * i;
                    if(score >= threshold){
                        Console.WriteLine(Convert.ToChar(65 + i));
                        return;
                    }
                }
                Console.WriteLine("F");
        }
    }
}