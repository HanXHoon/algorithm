using System.Linq;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine() ?? "";
            string [] univNameArr = {"Soongsil", "Korea", "Hanyang"};
            int [] univScoreArr = str.Split(' ')
                                    .Select(s => Convert.ToInt32(s))
                                    .ToArray();

            if(univScoreArr.Sum() < 100){
                int minValue = univScoreArr.Min();
                for(int i = 0 ; i < 3 ; i++){
                    if(univScoreArr[i] == minValue){
                        Console.WriteLine(univNameArr[i]);
                        break;
                    }
                }
            }else{
                Console.WriteLine("OK");
            }
        }
    }
}