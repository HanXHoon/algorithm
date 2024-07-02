namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCaseAmount = Convert.ToInt32(Console.ReadLine());
            string result = "";

            for(int i = 0; i < testCaseAmount; i++)
            {
                string bracketStr = Console.ReadLine() ?? "";
                bool existBracket = bracketStr.Contains("()");

                while(existBracket)
                {
                    bracketStr = bracketStr.Replace("()", "");
                    existBracket = bracketStr.Contains("()");
                }

                if (bracketStr.Length == 0)
                    result += "YES\n";
                else
                    result += "NO\n";
            }

            Console.WriteLine(result);
        }
    }
}