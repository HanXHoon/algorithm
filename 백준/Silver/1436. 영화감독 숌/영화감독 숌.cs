namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine()) - 1;
            int num = 666;
            while(true){
                if(N <= 0){
                    Console.WriteLine(num);
                    break;
                }

                num++;
                if(num.ToString().Contains("666"))
                    N--;
            }
        }
    }
}