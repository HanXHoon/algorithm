namespace ConsoleApp1
{
    internal class Program
    {
        public struct Coord
        {
            public int x;
            public int y;

            public Coord(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            int dataLen = Convert.ToInt32(Console.ReadLine());

            List<Coord> coordList = new List<Coord>();

            for(int i = 0; i < dataLen; i++)
            {
                string inputData = (Console.ReadLine() ?? "");
                string[] splitData = inputData.Split(' ');
                int x = Convert.ToInt32(splitData[0]);
                int y = Convert.ToInt32(splitData[1]);

                coordList.Add(new Coord(x, y));
            }

            var result = coordList.GroupBy(g => g.y)
                                    .OrderBy(o => o.Key)
                                    .Select(s1 => string.Join("\n", s1.OrderBy(s2 => s2.x).Select(s3 => $"{s3.x} {s3.y}")));

            Console.WriteLine(string.Join("\n", result));
        }
    }
}