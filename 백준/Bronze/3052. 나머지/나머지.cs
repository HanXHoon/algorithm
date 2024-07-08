Console.WriteLine(Enumerable.Range(0, 10)
    .Select(_ => Convert.ToInt32(Console.ReadLine()) % 42)
    .GroupBy(g => g)
    .Count()
    .ToString());