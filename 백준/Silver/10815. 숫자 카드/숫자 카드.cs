using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sanggeunCardNum = Convert.ToInt32(Console.ReadLine());
            string sanggeunDeckStr = Console.ReadLine() ?? "";
            int publicCardNum = Convert.ToInt32(Console.ReadLine());
            string publicDeckStr = Console.ReadLine() ?? "";

            StringBuilder resultSB = new StringBuilder();

            Dictionary<int, int> sanggeunDeck_dict = new Dictionary<int, int>();

            foreach (string card in sanggeunDeckStr.Split(' '))
            {
                int cardNum = Convert.ToInt32(card);
                if (sanggeunDeck_dict.ContainsKey(cardNum))
                    sanggeunDeck_dict[cardNum]++;
                else
                    sanggeunDeck_dict.Add(cardNum, 1);
            }

            string[] deck = publicDeckStr.Split(' ');

            for (int i = 0; i < publicCardNum; i++)
            {
                int findCardNum = Convert.ToInt32(deck[i]);
                if (sanggeunDeck_dict.ContainsKey(findCardNum))
                    resultSB.Append("1 ");
                else
                    resultSB.Append("0 ");
            }

            Console.WriteLine(resultSB.ToString().Trim());
        }
    }
}