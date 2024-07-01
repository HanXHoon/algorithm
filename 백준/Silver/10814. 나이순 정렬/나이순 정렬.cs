namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? sLen = Console.ReadLine();
            int len = Convert.ToInt32(sLen);
            string [] member_arr = new string[len];

            for(int i = 0 ; i < len ; i++){
                string? readLine = Console.ReadLine();
                member_arr[i] = readLine ?? "";
            }
            Solution(member_arr);
        }

        static void Solution(string[] para){
            var member_arr = para
                        .Select(s => s.Split(' '))
                        .ToArray()
                        .GroupBy(g => g[0])
                        .Select(group => new {Key = group.Key, Items = group.ToArray()})
                        .OrderBy(o => Convert.ToInt32(o.Key))
                        .ToArray();

            foreach(var group in member_arr){
                foreach(var item in group.Items){
                    Console.WriteLine(String.Join(" ", item));
                }
            }
        }
    }
}