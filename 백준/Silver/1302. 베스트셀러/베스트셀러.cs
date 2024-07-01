using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dataLen = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> bookSales = new Dictionary<string, int>();

            for (int i = 0; i < dataLen; i++)
            {
                string bookName = Console.ReadLine() ?? "";
                if (!bookSales.ContainsKey(bookName))
                {
                    bookSales[bookName] = 1;
                }
                else
                {
                    bookSales[bookName] += 1;
                }
            }

            int maxSales = bookSales.OrderByDescending(o => o.Value).First().Value;
            var result = bookSales.Where(w => w.Value >= maxSales)
                                .Select(s => s.Key)
                                .OrderBy(o => o)
                                .First();

            Console.WriteLine(result);
        }
    }
}