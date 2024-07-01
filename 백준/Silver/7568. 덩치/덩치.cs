namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string? sLen = Console.ReadLine();
            int len = Convert.ToInt32(sLen);
            int[,] data = new int[len, 2];

            for (int i = 0; i < len; i++)
            {
                string readLine = Console.ReadLine() ?? "";
                string[] splitData = readLine.Split(' ');
                data[i,0] = Convert.ToInt32(splitData[0]);
                data[i,1] = Convert.ToInt32(splitData[1]);
            }
            Solution(data);
        }

        static void Solution(int[,] para)
        {
            int len = para.GetLength(0);
            int count = 0;

            for (int i = 0; i < len; i++)
            {
                int myWeight = para[i, 0];
                int myHeight = para[i, 1];

                count = 1;

                for (int k = 0; k < len; k++)
                {
                    if (i == k) continue;
                    if(myWeight < para[k, 0] && myHeight < para[k, 1])
                    { count++; }
                }
                Console.WriteLine(count);
            }
        }
    }
}